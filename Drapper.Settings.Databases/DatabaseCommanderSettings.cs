using System;
using System.Collections.Generic;
using System.Linq;
using Drapper.Validation;

namespace Drapper.Settings.Databases
{
    public class DatabaseCommanderSettings : IDatabaseCommanderSettings
    {
        public IEnumerable<INamespaceSetting<DatabaseCommandSetting>> Namespaces { get; }        
        public IEnumerable<ConnectionStringSetting> Connections { get; }

        public DatabaseCommanderSettings(            
            IEnumerable<DatabaseCommandNamespaceSetting> namespaces,
            IEnumerable<ConnectionStringSetting> connections)
        {
            Contract.Require<ArgumentNullException>(connections != null, nameof(connections));
            Contract.Require<ArgumentNullException>(namespaces != null, nameof(namespaces));

            var connectionStringSettings = connections as ConnectionStringSetting[] ?? connections.ToArray();
            Contract.Require<ArgumentException>(connectionStringSettings.Any(), Messages.EmptyConnectionStringSettingsList);

            var namespaceSettings = namespaces as DatabaseCommandNamespaceSetting[] ?? namespaces.ToArray();
            Contract.Require<ArgumentException>(namespaceSettings.Any(), Messages.EmptyNamespaceSettingsList);

            Connections = connectionStringSettings;
            Namespaces = namespaceSettings;
        }

        private static class Messages
        {
            internal const string EmptyConnectionStringSettingsList =
                "At least 1 ConnectionStringSetting was expected.";
            internal const string EmptyNamespaceSettingsList =
                    "At least 1 DatabaseCommandNamespaceSetting was expected to be passed to the DatabaseCommanderSettings constructor.";
        }
    }
}