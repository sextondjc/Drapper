// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Drapper.Validation.Contract;

namespace Drapper.Configuration.Json
{
    /// <summary>
    /// Returns command settings from a json file. 
    /// </summary>    
    public sealed class JsonFileCommandReader : ICommandReader
    {        
        private readonly ISettings _settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonFileCommandReader"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public JsonFileCommandReader(ISettings settings)
        {            
            _settings = settings;
        }
        
        public CommandSetting GetCommand(Type type, string key)
        {
            Require(type != null, ErrorMessages.NullTypePassed);
            Require(!string.IsNullOrWhiteSpace(key), ErrorMessages.EmptyKeyPassed, type.FullName);            
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
             *                      matched key: return definition entry. 
             *          matched type
             *              check definition path
             *                  null: check for definitions
             *                      not null: check for matching keys
             *                          no matching key: terminate and throw exception
             *                          matched key: return definition entry.
             *                      null: terminate and throw exception.
             *                  not null: search file matching name
             *                      no file found: terminate and throw exception
             *                      file found: deserialize and check for matching keys
             *                          no matching keys: terminate and throw exception
             *                          matched key: return definition entry.
             */

            // start from most specific and work your way down. 
            var namespaceSetting = GetNamespaceSetting(type);
            Require(namespaceSetting != null, ErrorMessages.NoNamesapceSettingForType, type.FullName);

            var typeSetting = GetTypeSetting(namespaceSetting, type);
            return GetCommandSetting(typeSetting, key);            
        }

        private NamespaceSetting GetNamespaceSetting(Type type)
        {
            // loop backwards till we find a match
            foreach (var setting in _settings.Namespaces)
            {
                var @namespace = type.Namespace;                
                var periods = @namespace.Count(x => x == '.');
                for (int i = periods; i > 0; i--)
                {
                    var entry = _settings.Namespaces.SingleOrDefault(x => x.Namespace == @namespace);
                    if (entry != null)
                    {
                        // we have a match. 
                        return entry;
                    }

                    @namespace = @namespace.Substring(0, @namespace.LastIndexOf('.'));
                }
            }

            // if we reach here, we've got nothing.
            return null;
        }

        private TypeSetting GetTypeSetting(NamespaceSetting namespaceSetting, Type type)
        {
            // check if it has a type setting.
            var typeSetting = namespaceSetting.Types?.SingleOrDefault(x => x.Name == type.FullName);

            // if it's not null, perhaps there's a definition in the settings file already.
            if(typeSetting != null)
            {
                return typeSetting;
            }            

            return GetTypeSettingFromFile(namespaceSetting, type);
        }

        private TypeSetting GetTypeSettingFromFile(NamespaceSetting namespaceSetting, Type type)
        {
            // if it's null here, try looking for a file from the namespace. 
            Require(namespaceSetting.Path != null, ErrorMessages.NoTypeSettingAndNoPathInNamespace, type.FullName, namespaceSetting.Namespace);
            var path = $"{namespaceSetting.Path.Directory}\\{type.FullName}.{namespaceSetting.Path.Extension}";

            // must have a path.            
            Require(!string.IsNullOrWhiteSpace(path), ErrorMessages.RequiredPathEmptyInNamespace, type.FullName, namespaceSetting.Namespace);
            Require(File.Exists(path), ErrorMessages.FileNotFoundWithNamespaceSetting, type.FullName, path, namespaceSetting.Namespace);

            // this should probably be in a try/catch but i'm leaving it exposed 
            // so that the deserialization exception is bubbled back up.
            var result = JsonConvert.DeserializeObject<TypeSetting>(File.ReadAllText(path));
            Require(result != null, ErrorMessages.FileDeserializedToNull);
            
            return result;
        }

        private CommandSetting GetCommandSetting(TypeSetting typeSetting, string key)
        {
            var entry = typeSetting.Commands?.SingleOrDefault(x => x.Key == key);

            // might be part of the type setting already.
            if(entry != null && entry.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(entry.Value.Key))
                {
                    return entry.Value.Value;
                }
            }

            return GetCommandSettingFromFile(typeSetting, key);
        }

        private CommandSetting GetCommandSettingFromFile(TypeSetting typeSetting, string key)
        {
            // or maybe in a file. 
            Require(typeSetting.Path != null, ErrorMessages.NoCommandSettingAndNoPathInTypeSetting, key, typeSetting.Name);
            var path = $"{typeSetting.Path.File}";

            // check that the path is cool & file exists. 
            Require(!string.IsNullOrWhiteSpace(path), ErrorMessages.RequiredPathEmptyInTypeSetting, key, typeSetting.Name);
            Require(File.Exists(path), ErrorMessages.FileNotFoundWithTypeSetting, key, path, typeSetting.Name);

            // parse...
            var definitions = JsonConvert.DeserializeObject<IDictionary<string, CommandSetting>>(File.ReadAllText(path));
            Require(definitions != null, ErrorMessages.CommandSettingsDictionaryIsNull, typeSetting.Name);

            var result = definitions.SingleOrDefault(x => x.Key == key).Value;
            Require(result != null, ErrorMessages.CommandSettingIsNull, typeSetting.Name, key);

            return result;
        }
        
        private static class ErrorMessages
        {
            internal const string NoNamesapceSettingForType =
@"'{0}' does not belong to any NamespaceSetting.
Please check configuration.";

            internal const string CommandSettingsDictionaryIsNull = 
@"The CommandSettings dictionary for '{0}' is null.";

            internal const string CommandSettingIsNull =
@"No CommandSetting could be found for '{0}' using key '{1}'.";

            internal const string NullTypePassed =
@"A null type was passed to the IDefinitionEntryParser. Types are used to locate query definition entries.
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
