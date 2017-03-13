// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Drapper.Tests.Helpers.TableHelper;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [Collection("Integration")]
    public class ExecuteAsync
    {
        [Fact]
        public async Task SupportParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.ExecuteAsync(typeof(ExecuteAsync));
            }
        }

        [Fact]        
        public async Task ExceptionsAreReturnedToParameterlessCaller()
        {
            using (var commander = CreateCommander())
            {
                var result = await ThrowsAsync<SqlException>(() => commander.ExecuteAsync(typeof(ExecuteAsync)));
            }
        }

        [Fact]
        public async Task ReturnsTrueForSuccessfulResult()
        {
            using (var commander = CreateCommander())
            {
                var response = await commander.ExecuteAsync(new { value = 1 }, typeof(ExecuteAsync));
                NotNull(response);
                IsType<bool>(response);
                True(response);
            }
        }

        [Fact]        
        public async Task ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                var result = await ThrowsAsync<SqlException>(() => commander.ExecuteAsync(new { value = 1 }, typeof(ExecuteAsync)));
            }
        }

        [Fact]        
        public void SupportsCancellationToken()
        {
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(3));

            using (var commander = CreateCommander())
            {
                var task = commander.ExecuteAsync(new { value = 1 }, typeof(ExecuteAsync), cancellationToken: tokenSource.Token);
                try
                {
                    task.Wait(TimeSpan.FromSeconds(5));                    
                }
                catch (Exception ex)
                {
                    IsType<AggregateException>(ex);
                    var innerExceptions = ((AggregateException)ex).InnerExceptions;
                    Equal(1, innerExceptions.Count());
                    IsType<SqlException>(innerExceptions.Single());
                    Equal("A severe error occurred on the current command.  The results, if any, should be discarded.\r\nOperation cancelled by user.", innerExceptions.Single().Message);                    
                }
            }
        }

        [Fact]
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
                var result = await commander.ExecuteAsync(models, typeof(ExecuteAsync));
                True(result);

                // check they were created. 
                var records = commander.Query<PocoA>(type: typeof(ExecuteAsync), method: "SupportsIEnumberableModelsAsync.Query");                
                NotNull(records);
                True(records.Any());
                Equal(2, records.Count());
                Equal(models.First().Name, records.First().Name);
                Equal(models.Last().Name, records.Last().Name);
            }
        }

        [Fact]        
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
                var result = await ThrowsAsync<SqlException>(() => commander.ExecuteAsync(models, typeof(ExecuteAsync)));
            }
        }

        [Fact]
        public async Task SupportsTransactionRollback()
        {
            var model = new PocoA { Name = Guid.NewGuid().ToString(), Value = int.MaxValue };
            using (var commander = CreateCommander())
            {
                var result = await ThrowsAsync<SqlException>(() => commander.ExecuteAsync(model, typeof(ExecuteAsync)));
                // check if the record has been rolled back.                    
                var records = commander.Query<PocoA>(new { Name = model.Name }, typeof(ExecuteAsync), "SupportsTransactionRollback.Query");
                NotNull(records);
                False(records.Any());
            }
        }

        [Fact]
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
                NotNull(result);
                True(result.Any());
                Equal(2, result.Count());

                // confirm the result corresponds to the poco's passed
                True(result.Any(x => x.Name == pocoA.Name));
                True(result.Any(x => x.Name == pocoB.Name));
            }

        }
    }
}
