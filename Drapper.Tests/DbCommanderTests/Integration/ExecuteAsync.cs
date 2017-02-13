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
using System.Threading;
using System.Threading.Tasks;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Drapper.Tests.Helpers.TableHelper;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class ExecuteAsync
    {        
        [TestMethod]
        public async Task ReturnsTrueForSuccessfulResult()
        {
            using (var commander = CreateCommander())
            {
                var response = await commander.ExecuteAsync(new { value = 1 });
                IsNotNull(response);
                IsInstanceOfType(response, typeof(bool));
                IsTrue(response);
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
                    Fail("The cancellation token didn't cancel.");
                }
                catch (Exception ex)
                {
                    IsInstanceOfType(ex, typeof(AggregateException));
                    var innerExceptions = ((AggregateException)ex).InnerExceptions;
                    AreEqual(1, innerExceptions.Count());
                    IsInstanceOfType(innerExceptions.Single(), typeof(SqlException));
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
                IsTrue(result);

                // check they were created. 
                var records = commander.Query<PocoA>(type: typeof(ExecuteAsync), method: "SupportsIEnumberableModelsAsync.Query");                
                IsNotNull(records);
                IsTrue(records.Any());
                AreEqual(2, records.Count());
                AreEqual(models.First().Name, records.First().Name);
                AreEqual(models.Last().Name, records.Last().Name);
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
                    IsInstanceOfType(ex, typeof(SqlException));
                    // check if the record has been rolled back.                    
                    var records = commander.Query<PocoA>(new { Name = model.Name },typeof(ExecuteAsync),"SupportsTransactionRollback.Query");
                    IsNotNull(records);
                    IsFalse(records.Any());
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

                ReferenceEquals(pocoA, record.PocoA);
                ReferenceEquals(pocoB, record.PocoB);              
            }

            // now query. 
            using (var commander = CreateCommander())
            {
                var result = commander.Query<MultiMapPocoB>(type: typeof(ExecuteAsync), method: "DistributedTransactionAsync.Query");
                IsNotNull(result);
                IsTrue(result.Any());
                AreEqual(2, result.Count());

                // confirm the result corresponds to the poco's passed
                IsTrue(result.Any(x => x.Name == pocoA.Name));
                IsTrue(result.Any(x => x.Name == pocoB.Name));
            }

        }
    }
}
