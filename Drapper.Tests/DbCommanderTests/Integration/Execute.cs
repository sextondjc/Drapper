// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Drapper.Tests.Common.CommanderHelper;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class Execute
    {
        #region / init & cleanup /
        
        public void CreateTable(string tableName)
        {
            TableHelper.CreateTable(tableName);
        }
        
        #endregion

        [TestMethod]
        public void ReturnsTrueForSuccessfulResult()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Execute(new { value = 1 });
                Assert.IsTrue(result);
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
                Assert.IsTrue(result);

                // check they were created. 
                var records = commander.Query<PocoA>(method: "SupportsIEnumberableModels.Query");
                Assert.IsNotNull(records);
                Assert.IsTrue(records.Any());
                Assert.AreEqual(2, records.Count());
                Assert.AreEqual(models.First().Name, records.First().Name);
                Assert.AreEqual(models.Last().Name, records.Last().Name);
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
                    Assert.IsInstanceOfType(ex, typeof(SqlException));
                    // check if the record has been rolled back.                    
                    var record = commander.Query<PocoA>(new { Name = model.Name }, method: "SupportsTransactionRollback.Query");
                    Assert.IsNotNull(record);
                    Assert.IsFalse(record.Any());
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

                Assert.ReferenceEquals(pocoA, record.PocoA);
                Assert.ReferenceEquals(pocoB, record.PocoB);
            }
        }
    }
}
