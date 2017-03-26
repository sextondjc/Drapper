// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Drapper.Configuration;
using Drapper.Tests.DbCommanderTests.Integration;
using Drapper.Tests.Fallback.Drapper.Tests.Fallback.Some.Other.Namespace;
using Drapper.Tests.Relative.Path.Tests;
using Xunit;
using static Xunit.Assert;
using System.Data.SqlClient;

namespace Drapper.Tests.DbConnectorTests
{    
    public class CreateDbConnection
    {
        #region / mocks /

        private ISettings _settings;

        public CreateDbConnection()
        {
            _settings = TestSettings();
        }

        private static Settings TestSettings()
        {
            // settings listed from least filled to most, 
            // kinda like you'd expect to see in a settings file

            return new Settings
            {
                Namespaces = new List<NamespaceSetting>
                {
                    new NamespaceSetting
                    {
                        Namespace = "Drapper" // to test missing fallback.
                    },
                    // to test fallback to namespace connection
                    new NamespaceSetting
                    {
                        Namespace = "Drapper.Tests",
                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true")
                    },
                    // to test fallback to type connection
                    new NamespaceSetting
                    {
                        Namespace = "Drapper.Tests.DbCommanderTests.Integration",
                        Types = new List<TypeSetting>
                        {
                            new TypeSetting
                            {
                                Name = "Drapper.Tests.DbCommanderTests.Integration.MultipleAsync",
                                ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true")
                            },
                            new TypeSetting
                            {
                                Name = "Drapper.Tests.DbCommanderTests.Integration.Multiple",
                                Commands = new Dictionary<string, CommandSetting>
                                {
                                    ["WithOneType"] = new CommandSetting
                                    {
                                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true"),
                                    }
                                }
                            },
                            new TypeSetting
                            {
                                Name = "Drapper.Tests.DbCommanderTests.Integration.Query",
                                ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=DoesNotExist;Integrated Security=true")
                            },
                            new TypeSetting
                            {
                                Name = "Drapper.Tests.DbCommanderTests.Integration.CollectionPocoB",
                                ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "haha! lol!")
                            }
                        }
                    },
                    new NamespaceSetting
                    {
                        Namespace = "Drapper.Tests.DbConnectorTests",
                        ConnectionString = new ConnectionStringSetting("InvalidClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true"),
                    },
                    new NamespaceSetting
                    {
                        Namespace = "Drapper.Tests.Fallback",
                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true")                        
                    },
                    new NamespaceSetting
                    {
                        Namespace = "Drapper.Tests.Relative.Path.Tests",
                        Types = new List<TypeSetting>
                        {
                            new TypeSetting
                            {
                                Name = typeof(TypeH).FullName,
                                Commands = new Dictionary<string, CommandSetting>
                                {
                                    ["Valid"] = new CommandSetting
                                    {
                                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true"),
                                    },
                                    ["WithoutProvider"] = new CommandSetting
                                    {
                                        ConnectionString = new ConnectionStringSetting(null, "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Drapper;Integrated Security=true"),
                                    },
                                    ["WithoutConnectionString"] = new CommandSetting
                                    {
                                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", null),
                                    },
                                }
                            }
                        }
                    }

                }
            };
        }

        #endregion

        [Fact]
        public void ValidProviderNameAndConnectionStringReturnsConnection()
        {            
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(typeof(Query));            
            NotNull(connection);
            Equal(ConnectionState.Closed, connection.State);            
        }

        [Fact]
        public void ConnectionFromCommandSettings()
        {
            var setting = _settings.Namespaces.Single(
                x => x.Namespace == "Drapper.Tests.Relative.Path.Tests").Types.Single(
                x => x.Name == "Drapper.Tests.Relative.Path.Tests.TypeH").Commands.Single(
                x => x.Key == "Valid");
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(typeof(TypeH), setting.Value);
            NotNull(connection);
        }

        [Fact]        
        public void ConnectionFromCommandSettingWithoutProviderThrowsArgumentNullException()
        {
            var setting = _settings.Namespaces.Single(
                x => x.Namespace == "Drapper.Tests.Relative.Path.Tests").Types.Single(
                x => x.Name == "Drapper.Tests.Relative.Path.Tests.TypeH").Commands.Single(
                x => x.Key == "WithoutProvider");
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(typeof(TypeH), setting.Value));
            Equal("Value cannot be null.\r\nParameter name: The providerName from the command setting cannot be null.", exception.Message);
        }

        [Fact]
        public void ConnectionFromCommandSettingNullProviderThrowsArgumentNullException()
        {
            var setting = _settings.Namespaces.Single(
                x => x.Namespace == "Drapper.Tests.Relative.Path.Tests").Types.Single(
                x => x.Name == "Drapper.Tests.Relative.Path.Tests.TypeH").Commands.Single(
                x => x.Key == "WithoutProvider");
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(null, setting.Value));
            Equal("Value cannot be null.\r\nParameter name: The 'type' variable passed to CreateDbConnection was null.", exception.Message);
        }

        [Fact]        
        public void ConnectionFromCommandSettingWithoutConnectionStringThrowsArgumentNullException()
        {
            var setting = _settings.Namespaces.Single(
                x => x.Namespace == "Drapper.Tests.Relative.Path.Tests").Types.Single(
                x => x.Name == "Drapper.Tests.Relative.Path.Tests.TypeH").Commands.Single(
                x => x.Key == "WithoutConnectionString");
            
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(typeof(TypeH), setting.Value));
            Equal("Value cannot be null.\r\nParameter name: The connectionString from the command setting cannot be null.", exception.Message);
        }

        [Fact]
        public void ConnectionFromCommandSettingNullConnectionStringThrowsArgumentNullException()
        {
            var setting = _settings.Namespaces.Single(
                x => x.Namespace == "Drapper.Tests.Relative.Path.Tests").Types.Single(
                x => x.Name == "Drapper.Tests.Relative.Path.Tests.TypeH").Commands.Single(
                x => x.Key == "WithoutConnectionString");

            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(typeof(TypeH), null));
            Equal($"Value cannot be null.\r\nParameter name: The command setting passed was null. Check configuration for type '{typeof(TypeH).FullName}'.", exception.Message);
        }

        [Fact]        
        public void InvalidProviderNameThrowsArgumentException()
        {            
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentException>(() => connector.CreateDbConnection(typeof(CreateDbConnection)));
            Equal("Unable to find the requested .Net Framework Data Provider.  It may not be installed.", exception.Message);
        }
        
        [Fact]        
        public void NullSettingThrowsArgumentNullException()
        {           
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(typeof(CollectionPocoA)));
            Equal($"Value cannot be null.\r\nParameter name: No connection string settings could be found for '{typeof(CollectionPocoA).FullName}'. Please check configuration.", exception.Message);
        }

        [Fact]        
        public void NullTypePassedThrowsArgumentNullException()
        {
            Type type = null;
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(type));
            Equal("Value cannot be null.\r\nParameter name: The 'type' variable passed to CreateDbConnection was null.", exception.Message);
        }
        
        [Fact]        
        public void NonExistentDatabaseThrowsException()
        {            
            var type = typeof(Query);
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);            
            var exception = Throws<SqlException>(() => connection.Open());            
        }
        
        [Fact]        
        public void MissingFallbackConnectionStringThrowsArgumentNullException()
        {
            var connector = new DbConnector(_settings);
            var exception = Throws<ArgumentNullException>(() => connector.CreateDbConnection(typeof(DbCommander)));
            Equal("Value cannot be null.\r\nParameter name: No connection string settings could be found for 'Drapper.DbCommander'. Please check configuration.", exception.Message);
        }

        [Fact]
        public void InvalidConnectionStringThrowsArgumentException()
        {
            var connector = new DbConnector(_settings);
            IDbConnection connection = null;
            try
            {
                var type = typeof(CollectionPocoB);
                connection = connector.CreateDbConnection(type);
            }
            catch (Exception ex)
            {                
                IsType<ArgumentException>(ex);
                // check that it's still null.
                Null(connection);
                Equal("Format of the initialization string does not conform to specification starting at index 0.", ex.Message);
            }            
        }

        [Fact]
        public void FallsbackToRootNamespaceConnection()
        {
            var type = typeof(FallbackConnectionType);
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);

            NotNull(connection);
            Equal(ConnectionState.Closed, connection.State);
        }
    }

    
}

namespace Drapper.Tests.Fallback
{
    namespace Drapper.Tests.Fallback.Some.Other.Namespace
    {
        public class FallbackConnectionType
        {
        }
    }
}