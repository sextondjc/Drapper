//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:05)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using Xunit;

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
            var result = Assert.Throws<ArgumentException>(() =>
                new DatabaseCommanderSettings(_namespaceSettings, new List<ConnectionStringSetting>()));
            Assert.Equal("At least 1 ConnectionStringSetting was expected.", result.Message);
        }

        [Fact]
        public void EmptyNamespaceSettingListThrowsArgumentException()
        {
            var result = Assert.Throws<ArgumentException>(() =>
                new DatabaseCommanderSettings(new List<DatabaseCommandNamespaceSetting>(), _connectionStringSettings));
            Assert.Equal(
                "At least 1 DatabaseCommandNamespaceSetting was expected to be passed to the DatabaseCommanderSettings constructor.",
                result.Message);
        }

        [Fact]
        public void NullConnectionStringSettingsThrowsArgumentNullException()
        {
            var result =
                Assert.Throws<ArgumentNullException>(() => new DatabaseCommanderSettings(_namespaceSettings, null));
            Assert.Equal("Value cannot be null.\r\nParameter name: connections", result.Message);
        }

        [Fact]
        public void NullNamespacesSettingThrowsArgumentNullException()
        {
            var result =
                Assert.Throws<ArgumentNullException>(() =>
                    new DatabaseCommanderSettings(null, _connectionStringSettings));
            Assert.Equal("Value cannot be null.\r\nParameter name: namespaces", result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new DatabaseCommanderSettings(_namespaceSettings, _connectionStringSettings);
            Assert.Equal(_connectionStringSettings, result.Connections);
            Assert.Equal(_namespaceSettings, result.Namespaces);
        }
    }
}