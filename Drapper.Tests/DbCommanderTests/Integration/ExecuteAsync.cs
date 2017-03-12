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
using System.Threading;
using System.Threading.Tasks;
using static Drapper.Tests.Common.CommanderHelper;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class ExecuteAsync
    {
        #region / init & cleanup /
        
        public void CreateTable(string tableName)
        {
            TableHelper.CreateTable(tableName);
        }
        
        #endregion

        [TestMethod]
        public async Task ReturnsTrueForSuccessfulResult()
        {
            using (var commander = CreateCommander())
            {
                var response = await commander.ExecuteAsync(new { value = 1 });
                Assert.IsNotNull(response);
                Assert.IsInstanceOfType(response, typeof(bool));
                Assert.IsTrue(response);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public async Task ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.ExecuteAsync(new { value = 1 });
            }
        }

        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void SupportsCancellationToken()
        {
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(3));

            using (var commander = CreateCommander())
            {
                var task = commander.ExecuteAsync(new { value = 1 }, typeof(ExecuteAsync), cancellationToken: tokenSource.Token);
                try
                {
                    task.Wait(TimeSpan.FromSeconds(5));
                    Assert.Fail("The cancellation token didn't cancel.");
                }
                catch (Exception ex)
                {
                    Assert.IsInstanceOfType(ex, typeof(AggregateException));
                    var innerExceptions = ((AggregateException)ex).InnerExceptions;
                    Assert.AreEqual(1, innerExceptions.Count());
                    Assert.IsInstanceOfType(innerExceptions.Single(), typeof(SqlException));
                    throw;
                }
            }
        }

        [TestMethod]
        public async Task SupportsIEnumberableModels()
        {
            CreateTable("EnumerableModelsAsync");
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
                var result = await commander.ExecuteAsync(models);
                Assert.IsTrue(result);

                // check they were created. 
                var records = commander.Query<PocoA>(type: typeof(ExecuteAsync), method: "SupportsIEnumberableModelsAsync.Query");                
                Assert.IsNotNull(records);
                Assert.IsTrue(records.Any());
                Assert.AreEqual(2, records.Count());
                Assert.AreEqual(models.First().Name, records.First().Name);
                Assert.AreEqual(models.Last().Name, records.Last().Name);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public async Task IEnumerableExecuteExceptionsAreReturnedToCaller()
        {
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
                var result = await commander.ExecuteAsync(models);
            }
        }

        [TestMethod]
        public async Task SupportsTransactionRollback()
        {
            var model = new PocoA { Name = Guid.NewGuid().ToString(), Value = int.MaxValue };
            using (var commander = CreateCommander())
            {
                try
                {
                    var result = await commander.ExecuteAsync(model);
                }
                catch (Exception ex)
                {
                    Assert.IsInstanceOfType(ex, typeof(SqlException));
                    // check if the record has been rolled back.                    
                    var records = commander.Query<PocoA>(new { Name = model.Name },typeof(ExecuteAsync),"SupportsTransactionRollback.Query");
                    Assert.IsNotNull(records);
                    Assert.IsFalse(records.Any());
                }
            }
        }

        [TestMethod]
        public async Task AsynchronousDistributedTransactionIsSuccessfulAndReturnsResult()
        {
            const string tableName = "DistributedTransactionAsync";
            CreateTable(tableName);
            var pocoA = new PocoA { Name = Guid.NewGuid().ToString(), Value = 1 };
            var pocoB = new PocoB { Name = Guid.NewGuid().ToString(), Value = 2 };

            using (var commander = CreateCommander())
            {
                var record = await commander.ExecuteAsync(() =>
                {
                    var t1 = commander.Execute(pocoA, typeof(Execute), method: tableName) ? pocoA : null;
                    var t2 = commander.Execute(pocoB, typeof(Execute), method: tableName) ? pocoB : null;
                    return new MultiMapPocoB
                    {
                        PocoA = t1,
                        PocoB = t2
                    };
                });

                Assert.ReferenceEquals(pocoA, record.PocoA);
                Assert.ReferenceEquals(pocoB, record.PocoB);              
            }

            // now query. 
            using (var commander = CreateCommander())
            {
                var result = commander.Query<MultiMapPocoB>(type: typeof(ExecuteAsync), method: "DistributedTransactionAsync.Query");
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Any());
                Assert.AreEqual(2, result.Count());

                // confirm the result corresponds to the poco's passed
                Assert.IsTrue(result.Any(x => x.Name == pocoA.Name));
                Assert.IsTrue(result.Any(x => x.Name == pocoB.Name));
            }

        }
    }
}
