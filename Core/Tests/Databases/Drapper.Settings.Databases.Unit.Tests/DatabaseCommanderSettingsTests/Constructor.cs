//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Settings.Databases.Unit.Tests.DatabaseCommanderSettingsTests
{
    public class Constructor
    {
        public Constructor()
        {
            _connectionStringSettings = new List<ConnectionStringSetting>
            {
                new ConnectionStringSetting("test", "providerName", "connectionString")
            };

            _namespaceSettings = new List<DatabaseCommandNamespaceSetting>
            {
                new DatabaseCommandNamespaceSetting("test.namespace", new List<DatabaseCommandTypeSetting>
                {
                    new DatabaseCommandTypeSetting("test.type", new Dictionary<string, DatabaseCommandSetting>
                    {
                        ["Retrieve"] = new DatabaseCommandSetting("alias", "select 1")
                    })
                })
            };
        }

        private readonly IEnumerable<DatabaseCommandNamespaceSetting> _namespaceSettings;
        private readonly IEnumerable<ConnectionStringSetting> _connectionStringSettings;

        [Fact]
        public void EmptyConnectionStringSettingListThrowsArgumentException()
        {
            var result = Throws<ArgumentException>(() =>
                new DatabaseCommanderSettings(_namespaceSettings, new List<ConnectionStringSetting>()));
            Equal("At least 1 ConnectionStringSetting was expected.", result.Message);
        }

        [Fact]
        public void EmptyNamespaceSettingListThrowsArgumentException()
        {
            var result = Throws<ArgumentException>(() =>
                new DatabaseCommanderSettings(new List<DatabaseCommandNamespaceSetting>(), _connectionStringSettings));
            Equal(
                "At least 1 DatabaseCommandNamespaceSetting was expected to be passed to the DatabaseCommanderSettings constructor.",
                result.Message);
        }

        [Fact]
        public void NullConnectionStringSettingsThrowsArgumentNullException()
        {
            var result =
                Throws<ArgumentNullException>(() => new DatabaseCommanderSettings(_namespaceSettings, null));
            Equal("Value cannot be null.\r\nParameter name: connections", result.Message);
        }

        [Fact]
        public void NullNamespacesSettingThrowsArgumentNullException()
        {
            var result =
                Throws<ArgumentNullException>(() =>
                    new DatabaseCommanderSettings(null, _connectionStringSettings));
            Equal("Value cannot be null.\r\nParameter name: namespaces", result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommanderSettings(_namespaceSettings, _connectionStringSettings);
            Equal(_connectionStringSettings, result.Connections);
            Equal(_namespaceSettings, result.Namespaces);
        }
    }
}