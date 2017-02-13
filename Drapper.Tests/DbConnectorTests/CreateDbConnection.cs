// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Drapper.Configuration;
using Drapper.Tests.DbCommanderTests.Integration;
using Drapper.Tests.Fallback.Drapper.Tests.Fallback.Some.Other.Namespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Drapper.Tests.DbConnectorTests
{
    [TestClass]
    public class CreateDbConnection
    {
        #region / mocks /

        private ISettings _settings;
        
        [TestInitialize]
        public void Initialize()
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
                    }

                }
            };
        }


        #endregion

        [TestMethod]
        public void ValidProviderNameAndConnectionStringReturnsConnection()
        {            
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(typeof(Query));            
            Assert.IsNotNull(connection);
            Assert.AreEqual(ConnectionState.Closed, connection.State);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidProviderNameThrowsArgumentException()
        {            
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(typeof(CreateDbConnection));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullSettingThrowsArgumentException()
        {           
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(typeof(CollectionPocoA));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullTypePassedThrowsArgumentException()
        {
            Type type = null;
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);
        }
        
        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void NonExistentDatabaseThrowsException()
        {            
            var type = typeof(Query);
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);
            Assert.IsNotNull(connection);
            Assert.AreEqual(ConnectionState.Closed, connection.State);

            connection.Open();            
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MissingFallbackConnectionStringThrowsArgumentException()
        {
            var type = typeof(DbCommander);
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);
        }

        [TestMethod]
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
                Assert.IsInstanceOfType(ex, typeof(ArgumentException));

                // check that it's still null.
                Assert.IsNull(connection);
            }            
        }

        [TestMethod]
        public void FallsbackToRootNamespaceConnection()
        {
            var type = typeof(FallbackConnectionType);
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);

            Assert.IsNotNull(connection);
            Assert.AreEqual(ConnectionState.Closed, connection.State);
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