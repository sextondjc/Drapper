using System;
using System.Collections.Generic;
using Drapper.Settings.Databases;
using Xunit;

namespace Drapper.Connectors.Databases.SqlServer.Unit.Tests.SqlServerDatabaseConnectorTests
{
    public class Constructor
    {
        private readonly IDatabaseCommanderSettings _settings;

        public Constructor()
        {
            _settings = new DatabaseCommanderSettings(
                new List<DatabaseCommandNamespaceSetting> {
                    new DatabaseCommandNamespaceSetting(
                        typeof(DatabaseCommandNamespaceSetting).Namespace,
                        new List<DatabaseCommandTypeSetting>
                        {
                            new DatabaseCommandTypeSetting(
                                typeof(DatabaseCommandTypeSetting).FullName,
                                new Dictionary<string, DatabaseCommandSetting>
                                {
                                    ["Retrieve"] = new DatabaseCommandSetting("test.alias", "select 'Readers.Test.Settings'")
                                })
                        })
                }
                , new List<ConnectionStringSetting>
                {
                    new ConnectionStringSetting("test.alias", "providerName", "connectionString")
                });
        }

        [Fact]
        public void NullSettingsThrowsArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => new SqlServerDatabaseConnector(null));
            Assert.Equal("Value cannot be null.\r\nParameter name: settings", result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var result = new SqlServerDatabaseConnector(_settings);
            Assert.NotNull(result);
        }
    }
}
