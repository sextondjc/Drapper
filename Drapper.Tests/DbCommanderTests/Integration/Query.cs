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

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [Collection("Integration")]
    public class Query
    {

        [Fact]
        public void SupportsParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {                
                var result = commander.Query<PocoA>();
                                
                NotNull(result);
                IsAssignableFrom<IEnumerable<PocoA>>(result);
                True(result.Any());
                Equal(5, result.Count());

                // check values 
                var first = result.First();
                Equal(1, first.PocoA_Id);
                Equal("A11", first.Name);
                Equal(1, first.Value);
                Equal(DateTime.UtcNow.Date, first.Modified.Date);
            }
        }

        [Fact]        
        public void ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                try
                {
                    var result = commander.Query<int>();
                }
                catch (SqlException exception)
                {
                    IsType<SqlException>(exception);                    
                }
                catch(Exception ex)
                {
                    True(false, "SqlException was expected.");
                }
                
            }
        }

        [Fact]
        public void SupportsParameterizedCalls()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query<PocoA>(new { Id = 3 });
                NotNull(result);
                IsAssignableFrom<IEnumerable<PocoA>>(result);
                True(result.Any());
                Equal(1, result.Count());

                // check values 
                var first = result.First();
                Equal(3, first.PocoA_Id);
                Equal("A13", first.Name);
                Equal(3, first.Value);
                Equal(DateTime.UtcNow.Date, first.Modified.Date);
            }
        }

        [Fact]
        public void ReturnsIdentity()
        {
            // not really an "execute" method, but:
            //  returning scope_identity is more of 
            //  "return" value (GET) than it is a 
            //  persistence operation. it's the 
            //  second half of a two part operation.
            const string tableName = "IdentityTest";
            CreateTable(tableName); 
            var model = new PocoA { Name = Guid.NewGuid().ToString(), Value = 1 };
            using (var commander = CreateCommander())
            {
                commander.Execute(() =>
                {
                    var result = commander.Query<int>(new { model.Name, model.Value }, typeof(Execute), "ReturnsIdentity");
                    Equal(1, result.Single());
                    result = commander.Query<int>(new { model.Name, model.Value }, typeof(Execute), "ReturnsIdentity");
                    Equal(2, result.Single());
                    result = commander.Query<int>(new { model.Name, model.Value }, typeof(Execute), "ReturnsIdentity");
                    Equal(3, result.Single());
                    return result;
                });
            }
        }
    }    
}
