using System;
using System.Collections.Generic;
using System.Data.Common;
using Drapper.Settings.Databases;
using Moq;
using Xunit;

namespace Drapper.Connectors.Databases.Unit.Tests.DatabaseConnectorTests
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
            var providerMock = new Mock<DbProviderFactory>();
            var result = Assert.Throws<ArgumentNullException>(() => new DatabaseConnector(null, () => providerMock.Object));
            Assert.Equal("Value cannot be null.\r\nParameter name: settings", result.Message);
        }

        [Fact]
        public void NullPredicateThrowsArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => new DatabaseConnector(_settings, null));
            Assert.Equal("Value cannot be null.\r\nParameter name: providerPredicate", result.Message);
        }

        [Fact]
        public void Successfully()
        {
            var providerMock = new Mock<DbProviderFactory>();
            var result = new DatabaseConnector(_settings, () => providerMock.Object);
            Assert.NotNull(result);
        }
    }
}
