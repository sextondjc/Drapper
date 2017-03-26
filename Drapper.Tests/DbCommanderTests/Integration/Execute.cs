// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Drapper.Tests.Helpers.TableHelper;
using Xunit;
using static Xunit.Assert;
using Drapper.Tests.Helpers;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [Collection("Integration")]
    public class Execute
    {
        DatabaseFixture _fixture;

        public Execute(DatabaseFixture fixture)
        {            
            _fixture = fixture;
        }

        [Fact]
        public void SupportParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {                 
                var result = commander.Execute<bool>();
            }
        }

        [Fact]        
        public void ParameterlessCallReturnsException()
        {
            using (var commander = CreateCommander())
            {
                // not the preferred way of testing exceptions
                // in xUnit, but because the parameterless calls
                // depend - for the moment - on a StackFrame, 
                // calling this method from within a Throws<T>
                // alters the stack & thus, the lookup. 
                try
                {
                    var result = commander.Execute<bool>();
                }
                catch (SqlException exception)
                {
                    IsType<SqlException>(exception);                    
                }
                catch (Exception ex)
                {
                    True(false, $"SqlException was expected. '{ex.GetType().FullName}' was returned.");
                    throw;
                }
            }
        }

        [Fact]
        public void ReturnsTrueForSuccessfulResult()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Execute(new { value = 1 });
                True(result);
            }
        }

        [Fact]        
        public void ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                var result = Throws<SqlException>(() => commander.Execute(new { value = 1 }, typeof(Execute)));
            }
        }

        [Fact]
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
                True(result);

                // check they were created. 
                var records = commander.Query<PocoA>(method: "SupportsIEnumberableModels.Query");
                NotNull(records);
                True(records.Any());
                Equal(2, records.Count());
                Equal(models.First().Name, records.First().Name);
                Equal(models.Last().Name, records.Last().Name);
            }
        }

        [Fact]        
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
                var result = Throws<SqlException>(() => commander.Execute((IEnumerable<dynamic>)models, type:typeof(Execute)));
            }
        }

        [Fact]
        public void SupportsTransactionRollback()
        {
            var model = new PocoA { Name = Guid.NewGuid().ToString(), Value = int.MaxValue };
            using (var commander = CreateCommander())
            {
                var result = Throws<SqlException>(() => commander.Execute(model, typeof(Execute)));

                // check if the record has been rolled back.
                var record = commander.Query<PocoA>(new { Name = model.Name }, method: "SupportsTransactionRollback.Query");
                NotNull(record);
                False(record.Any());                
            }
        }

        [Fact]
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

                Same(pocoA, record.PocoA);
                Same(pocoB, record.PocoB);
            }
        }
        
        [Fact]
        public void SupportBulkInsertFromFile()
        {
            var path = BulkFileCreator.CreateBulkFile();
            using (var commander = CreateCommander())
            {
                commander.Execute<bool>(method: "TruncateBulkInsertTable");
                var operation = commander.Execute(new { path });
                var result = commander.Query<dynamic>(method: "BulkInsertResult");
                Equal(1000, result.Count());
            }
        }
        
        [Fact]
        public void SupportBulkInsertFromFileAndReturn()
        {
            var path = BulkFileCreator.CreateBulkFile();
            using (var commander = CreateCommander())
            {
                commander.Execute<bool>(method: "TruncateBulkInsertTable");
                var result = commander.Query<dynamic>(new { path });
                Equal(1000, result.Count());
            }
        }
        
        [Fact]
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
                    LastName = $"LastName {i}"
                });
            }

            using (var commander = CreateCommander())
            {
                commander.Execute<bool>(method: "TruncateBulkInsertTable");
                var operation = commander.Execute(list);
                var result = commander.Query<dynamic>(method: "SupportBulkInsertFromListResult");
                Equal(1000, result.Count());
            }
        }       
    }
}
