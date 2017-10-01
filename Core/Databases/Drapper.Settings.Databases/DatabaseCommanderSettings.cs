//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using static Drapper.Validation.Contract;

namespace Drapper.Settings.Databases
{
    public class DatabaseCommanderSettings : IDatabaseCommanderSettings
    {
        public DatabaseCommanderSettings(
            IEnumerable<DatabaseCommandNamespaceSetting> namespaces,
            IEnumerable<ConnectionStringSetting> connections)
        {
            Require<ArgumentNullException>(connections != null, nameof(connections));
            Require<ArgumentNullException>(namespaces != null, nameof(namespaces));

            var connectionStringSettings = connections as ConnectionStringSetting[] ?? connections.ToArray();
            Require<ArgumentException>(connectionStringSettings.Any(),
                Messages.EmptyConnectionStringSettingsList);

            var namespaceSettings = namespaces as DatabaseCommandNamespaceSetting[] ?? namespaces.ToArray();
            Require<ArgumentException>(namespaceSettings.Any(), Messages.EmptyNamespaceSettingsList);

            Connections = connectionStringSettings;
            Namespaces = namespaceSettings;
        }

        public IEnumerable<INamespaceSetting<DatabaseCommandSetting>> Namespaces { get; }
        public IEnumerable<ConnectionStringSetting> Connections { get; }
        public IEnumerable<Type> Types { get; set; }

        private static class Messages
        {
            internal const string EmptyConnectionStringSettingsList =
                "At least 1 ConnectionStringSetting was expected.";

            internal const string EmptyNamespaceSettingsList =
                    "At least 1 DatabaseCommandNamespaceSetting was expected to be passed to the DatabaseCommanderSettings constructor."
                ;
        }
    }
}