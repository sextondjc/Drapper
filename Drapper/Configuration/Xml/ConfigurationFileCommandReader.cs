// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using static Drapper.Validation.Contract;
using static Drapper.Validation.Validator;

namespace Drapper.Configuration.Xml
{
    /// <summary>
    /// Concrete implementaion of the <see cref="ICommandReader"/> to support .config files.
    /// </summary>    
    public sealed class ConfigurationFileCommandReader : ICommandReader
    {
        /// <summary>
        /// Gets the command setting
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="key">The key.</param>        
        public CommandSetting GetCommand(Type type, string key)
        {
            Require(type != null, ErrorMessages.NullTypePassed);
            Require(!string.IsNullOrWhiteSpace(key), ErrorMessages.NullKeyPassed);
            
            var section = DrapperConfigurationSection.GetConfiguration();

            Require(section != null, ErrorMessages.NoSectionDefinition);

            var @namespace = GetNamespaceSettingElement(section, type);
            Require(@namespace != null, ErrorMessages.NoNamespaceEntry, type.Namespace);

            var typeSetting = GetTypeSettingElement(@namespace, type);
            Require(typeSetting != null, ErrorMessages.UnknownType, type);

            var entry = GetCommandSetting(typeSetting, key);
            Require(entry != null, ErrorMessages.NoCommandSetting, type, key);

            var result = new CommandSetting
            {
                CommandText = entry.CommandText,
                CommandTimeout = entry.CommandTimeout,
                CommandType = entry.CommandType,
                Flags = entry.Flags,
                Split = entry.Split,
                IsolationLevel = entry.IsolationLevel
            };
            
            Validate(result);

            return result;
        }

        private NamespaceSettingElement GetNamespaceSettingElement(DrapperConfigurationSection section, Type type)
        {
            foreach (NamespaceSettingElement setting in section.Namespaces)
            {
                var @namespace = type.Namespace;
                var periods = @namespace.Count(x => x == '.');
                for (int i = periods; i > 0; i--)
                {
                    var entry = section.Namespaces[@namespace];
                    if (entry != null)
                    {
                        // we have a match. 
                        return entry;
                    }

                    @namespace = @namespace.Substring(0, @namespace.LastIndexOf('.'));
                }
            }
            return null;
        }

        private TypeSettingElement GetTypeSettingElement(NamespaceSettingElement namespaceSetting, Type type)
        {
            var typeSetting = namespaceSetting.Types[type.FullName];
            if (typeSetting != null)
            {
                return typeSetting;
            }
            return null;
        }

        private CommandSettingElement GetCommandSetting(TypeSettingElement typeSetting, string key)
        {
            var entry = typeSetting.Methods[key];
            if(entry != null)
            {                
                return entry.CommandSetting;
            }
            return null;
        }

        private class ErrorMessages
        {
            internal const string NullTypePassed = "A type name was expected.";
            internal const string NullKeyPassed = "A key name was expected.";
            internal const string UnknownType = "No type entry could be found for {0}.";
            internal const string NoCommandSetting = "No CommandSetting could be found for {0}.{1}";
            internal const string NoNamespaceEntry = "The namespace {0} entry could not be found.";
            internal const string NoSectionDefinition = "No configuration section could be found for Drapper.";

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
        }
    }
}
