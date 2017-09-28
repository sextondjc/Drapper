using System;
using System.Linq;
using Drapper.Settings;
using Drapper.Settings.Databases;
using static Drapper.Validation.Contract;

namespace Drapper.Readers.Databases
{
    public class DatabaseCommandReader : IDatabaseCommandReader
    {
        private readonly IDatabaseCommanderSettings _settings;

        public DatabaseCommandReader(IDatabaseCommanderSettings settings)
        {
            Require<ArgumentNullException>(settings != null, "{0}. No settings were passed to DatabaseCommandReader.",nameof(settings));
            _settings = settings;
        }

        public DatabaseCommandSetting GetCommand(Type type, string key)
        {
            Require<ArgumentNullException>(type != null, nameof(type));
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(key), nameof(key));

            var namespaceSetting = GetNamespaceSetting(type);
            Require<NullReferenceException>(
                namespaceSetting != null, 
                ErrorMessages.NoNamespaceSettingForType, 
                type.FullName);

            var typeSetting = GetTypeSetting(namespaceSetting, type);
            Require<NullReferenceException>(typeSetting != null, 
                ErrorMessages.NoTypeSettingAndNoPathInNamespace,
                type.FullName,
                namespaceSetting.Namespace);

            var commandSetting = GetCommandSetting(namespaceSetting, typeSetting, key);
            Require<NullReferenceException>(commandSetting != null, 
                ErrorMessages.NoCommandSetting,
                key,
                typeSetting.Name);

            return commandSetting;
        }

        private INamespaceSetting<DatabaseCommandSetting> GetNamespaceSetting(Type type)
        {            
            //return _settings.Namespaces.SingleOrDefault(x => x.Namespace == type.Namespace);
            var result = _settings.Namespaces.SingleOrDefault(x => x.Namespace == type.Namespace);

            if (result != null)
            {
                return result;
            }

            // loop backwards till we find a match
            foreach (var setting in _settings.Namespaces)
            {
                var typeNamespace = type.Namespace;
                var periods = typeNamespace.Count(x => x == '.');

                for (var i = periods; i > 0; i--)
                {
                    if (setting.Namespace == typeNamespace)
                    {
                        return setting;
                    }
                    typeNamespace = typeNamespace.Substring(0, typeNamespace.LastIndexOf('.'));
                }
            }

            // if we reach here, we've got nothing.
            return null;
        }

        private ITypeSetting<DatabaseCommandSetting> GetTypeSetting(
            INamespaceSetting<DatabaseCommandSetting> namespaceSetting,
            Type type)
        {
            // check if it has a type setting.
            return namespaceSetting.Types?.SingleOrDefault(x => x.Name == type.FullName);            
        }

        private DatabaseCommandSetting GetCommandSetting(
            INamespaceSetting<DatabaseCommandSetting> namespaceSetting,
            ITypeSetting<DatabaseCommandSetting> typeSetting,
            string key)
        {
            var entry = typeSetting.Commands?.SingleOrDefault(x => x.Key == key);


            // might be part of the type setting already.
            if (entry != null)
            {
                if (!string.IsNullOrWhiteSpace(entry.Value.Key))
                {
                    return entry.Value.Value;
                }
            }


            return entry.Value.Value;

            //return typeSetting.CommandSetting;
        }


        private static class ErrorMessages
        {
            internal const string NoNamespaceSettingForType =
                @"'{0}' does not belong to any NamespaceSetting.
Please check settings.";

            internal const string NoTypeSettingAndNoPathInNamespace =
                @"The type '{0}' has no entry in the type settings of namespace '{1}'. Please add a type setting entry to the namespace setting.";

            internal const string NoCommandSetting =
                @"The command setting '{0}' has no entry for the type setting '{1}'. Please add a command setting entry to the type setting.";
        }
    }        
}