// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Drapper.Tests.Helpers.TableHelper;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class Execute
    {

        [TestMethod]
        public void SupportParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Execute();
            }
        }

        [TestMethod]
        public void ReturnsTrueForSuccessfulResult()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Execute(new { value = 1 });
                IsTrue(result);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Execute(new { value = 1 });
            }
        }

        [TestMethod]
        public void SupportsIEnumberableModels()
        {
            CreateTable("EnumerableModels");
            var models = new List<PocoA>
            {
                new PocoA
                {
                    PocoA_Id = 1,
                    Name = Guid.NewGuid().ToString(),
                    Value = 1,
                    Modified = DateTime.UtcNow,
                },
                new PocoA
                {
                    PocoA_Id = 2,
                    Name = Guid.NewGuid().ToString(),
                    Value = 2,
                    Modified = DateTime.UtcNow,
                }
            };

            using (var commander = CreateCommander())
            {
                var result = commander.Execute(models);
                IsTrue(result);

                // check they were created. 
                var records = commander.Query<PocoA>(method: "SupportsIEnumberableModels.Query");
                IsNotNull(records);
                IsTrue(records.Any());
                AreEqual(2, records.Count());
                AreEqual(models.First().Name, records.First().Name);
                AreEqual(models.Last().Name, records.Last().Name);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void IEnumerableExecuteExceptionsAreReturnedToCaller()
        {
            var models = new List<dynamic>
            {
                new { value = 1},
                new { value = 2},
                new { value = 3}
            };
            using (var commander = CreateCommander())
            {
                var result = commander.Execute((IEnumerable<dynamic>)models);
            }
        }

        [TestMethod]
        public void SupportsTransactionRollback()
        {
            var model = new PocoA { Name = Guid.NewGuid().ToString(), Value = int.MaxValue };
            using (var commander = CreateCommander())
            {
                try
                {
                    var result = commander.Execute(model);
                }
                catch (Exception ex)
                {
                    IsInstanceOfType(ex, typeof(SqlException));
                    // check if the record has been rolled back.                    
                    var record = commander.Query<PocoA>(new { Name = model.Name }, method: "SupportsTransactionRollback.Query");
                    IsNotNull(record);
                    IsFalse(record.Any());
                }
            }
        }

        [TestMethod]
        public void DistributedTransactionIsSuccessfulAndReturnsResult()
        {
            const string tableName = "DistributedTransaction";
            CreateTable(tableName);
            var pocoA = new PocoA { Name = Guid.NewGuid().ToString(), Value = 1 };
            var pocoB = new PocoB { Name = Guid.NewGuid().ToString(), Value = 2 };

            using (var commander = CreateCommander())
            {
                var record = commander.Execute(() =>
                {
                    var t1 = commander.Execute(pocoA, typeof(Execute), tableName) ? pocoA : null;
                    var t2 = commander.Execute(pocoB, typeof(Execute), tableName) ? pocoB : null;
                    return new MultiMapPocoB
                    {
                        PocoA = t1,
                        PocoB = t2
                    };
                });

                ReferenceEquals(pocoA, record.PocoA);
                ReferenceEquals(pocoB, record.PocoB);
            }
        }

        [Ignore] // todo: this is actually supported, but need to improve the test automation
        [TestMethod]
        public void SupportBulkInsertFromFile()
        {
            using (var commander = CreateCommander())
            {
                var operation = commander.Execute(new { path = "C:\\Github\\Drapper\\TestData\\CsvTest.txt" });
                var result = commander.Query<dynamic>(method: "BulkInsertResult");
                AreEqual(4, result.Count());
            }
        }

        [Ignore] // todo: this is actually supported, but need to improve the test automation
        [TestMethod]
        public void SupportBulkInsertFromFileAndReturn()
        {
            using (var commander = CreateCommander())
            {                                                
                var result = commander.Query<dynamic>(new { path = "C:\\Github\\Drapper\\TestData\\CsvTest.txt" });
                AreEqual(4, result.Count());
            }
        }

        [Ignore] // todo: this is actually supported, but need to improve the test automation
        [TestMethod]
        public void SupportBulkInsertFromList()
        {
            // build a list of 1000 items
            var list = new List<dynamic>();
            for (var i = 0; i < 1000; i++)
            {
                list.Add(new
                {
                    Id = i,
                    FirstName = $"FirstName {i}",
                    LastName = $"LastName {i}",
                    BirthDate = DateTime.UtcNow
                });
            }

            using (var commander = CreateCommander())
            {
                var operation = commander.Execute(list);
                var result = commander.Query<dynamic>(method: "SupportBulkInsertFromListResult");
                AreEqual(1000, result.Count());
            }
        }       
    }
}
