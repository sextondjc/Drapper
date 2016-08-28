// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        private Settings TestSettings()
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
                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=DrapperTests;Integrated Security=true")
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
                                ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=DrapperTests;Integrated Security=true")
                            },
                            new TypeSetting
                            {
                                Name = "Drapper.Tests.DbCommanderTests.Integration.Multiple",
                                Commands = new Dictionary<string, CommandSetting>
                                {
                                    ["WithOneType"] = new CommandSetting
                                    {
                                        ConnectionString = new ConnectionStringSetting("System.Data.SqlClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=DrapperTests;Integrated Security=true"),
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
                        ConnectionString = new ConnectionStringSetting("InvalidClient", "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=DrapperTests;Integrated Security=true"),
                    }
                }
            };
        }


        #endregion

        [TestMethod]
        public void ValidProviderNameAndConnectionStringReturnsConnection()
        {            
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(typeof(DbCommanderTests.Integration.Query));            
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
            var connection = connector.CreateDbConnection(typeof(Drapper.Tests.DbCommanderTests.Integration.CollectionPocoA));
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
            var type = typeof(Drapper.Tests.DbCommanderTests.Integration.Query);
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
            var type = typeof(Drapper.DbCommander);
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

                var type = typeof(Drapper.Tests.DbCommanderTests.Integration.CollectionPocoB);
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
            var type = typeof(Drapper.Tests.With.Additional.Levels.FallbackConnectionType);
            var connector = new DbConnector(_settings);
            var connection = connector.CreateDbConnection(type);

            Assert.IsNotNull(connection);
            Assert.AreEqual(ConnectionState.Closed, connection.State);
        }
    }
}

namespace Drapper.Tests.With.Additional.Levels
{
    public class FallbackConnectionType { }
}
