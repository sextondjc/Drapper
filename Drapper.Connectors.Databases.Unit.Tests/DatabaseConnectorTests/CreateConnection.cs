using System;
using System.Collections.Generic;
using System.Data.Common;
using Drapper.Settings.Databases;
using Moq;
using Xunit;

namespace Drapper.Connectors.Databases.Unit.Tests.DatabaseConnectorTests
{
    public class CreateConnection
    {
        private readonly IDatabaseCommanderSettings _settings;
        
        public CreateConnection()
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
        public void NullCommandSettingThrowsArgumentNullException()
        {
            var providerMock = new Mock<DbProviderFactory>();
            var connector = new DatabaseConnector(_settings, () => providerMock.Object);
            var result = Assert.Throws<ArgumentNullException>(() => connector.CreateConnection(null));
            Assert.Equal("Value cannot be null.\r\nParameter name: commandSetting", result.Message);
        }

        [Fact]
        public void NoAliasedConnectionThrowsNullReferenceException()
        {
            var providerMock = new Mock<DbProviderFactory>();
            var connector = new DatabaseConnector(_settings, () => providerMock.Object);
            var setting = new DatabaseCommandSetting("Does.Not.Exist", "test");

            var result = Assert.Throws<NullReferenceException>(() => connector.CreateConnection(setting));
            Assert.Equal( $"There is no connection with the alias '{setting.ConnectionAlias}' in the settings. Please check settings.", result.Message);
        }

        [Fact]
        public void ProviderReturnsNullConnectionThrowsNullReferenceException()
        {
            var providerMock = new Mock<DbProviderFactory>();
            providerMock.Setup(x => x.CreateConnection()).Returns(() => null);
            var connector = new DatabaseConnector(_settings, () => providerMock.Object);
            var setting = new DatabaseCommandSetting("test.alias", "select 1");
            var result = Assert.Throws<NullReferenceException>(() => connector.CreateConnection(setting));
            Assert.Equal(
                $"The provider predicate did not return a connection for the aliased connection '{setting.ConnectionAlias}'.",
                result.Message);            
        }

        [Fact]
        public void ProviderExceptionReturnedToCaller()
        {
            var providerMock = new Mock<DbProviderFactory>();
            providerMock.Setup(x => x.CreateConnection()).Throws(new NotImplementedException("Unit test"));
            var connector = new DatabaseConnector(_settings, () => providerMock.Object);
            var setting = new DatabaseCommandSetting("test.alias", "select 1");
            var result = Assert.Throws<NotImplementedException>(() => connector.CreateConnection(setting));
            Assert.Equal("Unit test", result.Message);            
        }

        [Fact]
        public void Successfully()
        {
            var connectionMock = new Mock<DbConnection>();
            var providerMock = new Mock<DbProviderFactory>();
            providerMock.Setup(x => x.CreateConnection()).Returns(() => connectionMock.Object);
            var connector = new DatabaseConnector(_settings, () => providerMock.Object);
            var setting = new DatabaseCommandSetting("test.alias", "select 1");
            var result = connector.CreateConnection(setting);
            Assert.NotNull(result);
            Assert.Equal(System.Data.ConnectionState.Closed, result.State);
        }
    }    
}
