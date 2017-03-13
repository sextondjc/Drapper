// ----------------------------------------------------------------------------------------------------------
// author   : David Sexton (sexto)
// created  : 2016-08-28 (23:44)
// modified : 2017-01-08 (18:53)
// 
// This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of 
// this source code package.
//  ----------------------------------------------------------------------------------------------------------

#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static Drapper.Validation.Contract;

#endregion

namespace Drapper.Configuration.Json
{
    /// <summary>
    ///     Returns command settings from a json file.
    /// </summary>
    public class JsonFileCommandReader : ICommandReader
    {
        private readonly ISettings _settings;
        private readonly CommandReaderUtilities _utilities;

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonFileCommandReader" /> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public JsonFileCommandReader(ISettings settings)
        {
            Require<ArgumentNullException>(settings != null, ErrorMessages.NullSettingsPassed);
            _settings = settings;
            _utilities = new CommandReaderUtilities(_settings);
        }

        public virtual CommandSetting GetCommand(Type type, string key)
        {            
            Require<ArgumentNullException>(type != null, ErrorMessages.NullTypePassed);
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(key),
                    ErrorMessages.EmptyKeyPassed,
                    type.FullName);
            return GetFromSettings(type, key);
        }

        private CommandSetting GetFromSettings(Type type, string key)
        {
            /* let's think about this flow for a sec...
             *  pass in a type & key. 
             *  get namespace setting, possibly decrementing till we get a match. 
             *  within that namespace
             *      check for matching types.
             *          no matching types
             *              use definition base path and search for files matching type name
             *                  no file found: terminate and throw exception
             *                  file found: deserialize & check for matching keys
             *                      no matching keys: terminate and throw exception. 
             *                      matched key: return command setting. 
             *          matched type
             *              check definition path
             *                  null: check for definitions
             *                      not null: check for matching keys
             *                          no matching key: terminate and throw exception
             *                          matched key: return command setting.
             *                      null: terminate and throw exception.
             *                  not null: search file matching name
             *                      no file found: terminate and throw exception
             *                      file found: deserialize and check for matching keys
             *                          no matching keys: terminate and throw exception
             *                          matched key: return command setting.
             */

            // pull in settingsfrom all sources first? 

            // start from most specific and work your way down. 
            var namespaceSetting = _utilities.GetNamespaceSetting(type);
            Require<ArgumentNullException>(namespaceSetting != null,
                    ErrorMessages.NoNamesapceSettingForType,
                    type.FullName);

            var typeSetting = _utilities.GetTypeSetting(namespaceSetting, type) ?? GetTypeSettingFromFile(namespaceSetting, type);
            return  _utilities.GetCommandSetting(namespaceSetting, typeSetting, key) ?? GetCommandSettingFromFile(namespaceSetting, typeSetting, key);
        }
        

        private TypeSetting GetTypeSettingFromFile(
            NamespaceSetting namespaceSetting,
            Type type)
        {
            // if it's null here, try looking for a file from the namespace. 
            Require<ArgumentNullException>(namespaceSetting.Path != null,
                    ErrorMessages.NoTypeSettingAndNoPathInNamespace,
                    type.FullName,
                    namespaceSetting.Namespace);
            var path = $"{namespaceSetting.Path.Directory}\\{type.FullName}.{namespaceSetting.Path.Extension}";

            // must have a path.            
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(path),
                    ErrorMessages.RequiredPathEmptyInNamespace,
                    type.FullName,
                    namespaceSetting.Namespace);

            Require<FileNotFoundException>(File.Exists(path),
                    ErrorMessages.FileNotFoundWithNamespaceSetting,
                    type.FullName,
                    path,
                    namespaceSetting.Namespace);

            // this should probably be in a try/catch but i'm leaving it exposed 
            // so that the deserialization exception is bubbled back up.
            var result = JsonConvert.DeserializeObject<TypeSetting>(File.ReadAllText(path));
            Require<ArgumentNullException>(result != null, ErrorMessages.FileDeserializedToNull);

            return result;
        }
        
        private CommandSetting GetCommandSettingFromFile(
            NamespaceSetting namespaceSetting,
            TypeSetting typeSetting,
            string key)
        {
            // or maybe in a file. 
            Require<ArgumentNullException>(typeSetting.Path != null,
                    ErrorMessages.NoCommandSettingAndNoPathInTypeSetting,
                    key,
                    typeSetting.Name);
            var path = $"{typeSetting.Path.File}";

            // check that the path is cool & file exists. 
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(path),
                    ErrorMessages.RequiredPathEmptyInTypeSetting,
                    key,
                    typeSetting.Name);

            // convert from relative to absolute (if it is). 
            path = _utilities.GetAbsolutePath(path, namespaceSetting?.Path?.Directory);

            Require<FileNotFoundException>(File.Exists(path),
                    ErrorMessages.FileNotFoundWithTypeSetting,
                    key,
                    path,
                    typeSetting.Name);

            // parse...
            var definitions =JsonConvert.DeserializeObject<IDictionary<string, CommandSetting>>(File.ReadAllText(path));
            Require<ArgumentNullException>(definitions != null,
                    ErrorMessages.CommandSettingsDictionaryIsNull,
                    typeSetting.Name);

            var result = definitions.SingleOrDefault(x => x.Key == key).Value;
            Require<ArgumentNullException>(result != null,
                    ErrorMessages.CommandSettingIsNull,
                    typeSetting.Name,
                    key);

            return result;
        }

        

        private static class ErrorMessages
        {
            internal const string NullSettingsPassed = "The ISettings instance passed was null.";

            internal const string NoNamesapceSettingForType =
@"'{0}' does not belong to any NamespaceSetting.
Please check configuration.";

            internal const string CommandSettingsDictionaryIsNull =
                @"The CommandSettings dictionary for '{0}' is null.";

            internal const string CommandSettingIsNull =
                @"No CommandSetting could be found for '{0}' using key '{1}'.";

            internal const string NullTypePassed =
@"A null type was passed to the ICommandReader. Types are used to locate query definition entries.
Please check configuration.";

            internal const string EmptyKeyPassed =
@"An empty key was passed for the type '{0}'. 
Keys are used to look up the query to execute and are usually the method name for the type.
Please check configuration.";

            internal const string NoTypeSettingAndNoPathInNamespace =
@"The type '{0}' has no entry in the type settings of namespace '{1}' and there is no path configured for this namespace where type settings files can be found.
Please either add a type setting entry to the namespace setting or configure a directory path to where type settings can be found.";

            internal const string RequiredPathEmptyInNamespace =
@"The type '{0}' has no entry in the type settings of namespace '{1}' and the path configured for this namespace is empty.
Please either add a type setting entry to the namespace setting or supply a directory path to where type settings can be found.";

            internal const string FileNotFoundWithNamespaceSetting =
@"The type '{0}' has a path configured at the namespace level but no such file exists.
The path used was {1} which was configured for namespace '{2}'";

            internal const string FileDeserializedToNull =
@"The type '{0}' is configured to get its settings from file '{1}' but this file did not deserialize correctly. 
Please check that it has been formatted correctly and the name property in the file correct.";

            internal const string NoCommandSettingAndNoPathInTypeSetting =
@"The command setting '{0}' has no entry for the type setting {1} and there is no path configured for this type where the command settings file can be found.
Please either add a command setting entry to the type setting or configure a file path where the command settings can be found.";

            internal const string RequiredPathEmptyInTypeSetting =
@"The command setting '{0}' has no entry in the type setting '{1}' and the path configured for this command setting is empty.
Please either add a command setting entry to the type setting or supply a file path where the command setting can be found.";

            internal const string FileNotFoundWithTypeSetting =
@"The command setting '{0}' has a path configured at the type level but no such file exists.
The path used was {1} which was configured for type '{2}'";
        }
    }
}