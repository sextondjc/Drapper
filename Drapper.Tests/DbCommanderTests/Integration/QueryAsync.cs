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
using Xunit;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Xunit.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [Collection("Integration")]
    public class QueryAsync
    {
        [Fact]
        public async Task SupportsParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {
                var response = await commander.QueryAsync<PocoA>(typeof(QueryAsync));
                var result = response.ToList();

                NotNull(result);
                IsAssignableFrom<IEnumerable<PocoA>>(result);
                True(result.Any());
                Equal(5, result.Count());
            }
        }

        [Fact]        
        public async Task ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {                
                var exception = await ThrowsAsync<SqlException>(() => commander.QueryAsync<int>(type: typeof(QueryAsync)));                
            }
        }

        [Fact]
        public async Task SupportsParameterizedCalls()
        {
            var date = new DateTime(2016, 4, 24);
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync<PocoA>(new { modified = date }, typeof(QueryAsync));
                NotNull(result);
                IsAssignableFrom<IEnumerable<PocoA>>(result);
                True(result.Any());
                Equal(3, result.Count());

                // check values 
                var first = result.First();
                Equal("Entry 1", first.Name);
                Equal(5.10M, first.Value);
                Equal(new DateTime(2016, 4, 24), first.Modified);
            }
        }

        [Fact]        
        public void SupportsCancellationToken()
        {            
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(3));

            using (var commander = CreateCommander())
            {
                var task = commander.QueryAsync<int>(type:typeof(QueryAsync), cancellationToken: tokenSource.Token);
                var exception = Throws<AggregateException>(() => task.Wait(TimeSpan.FromSeconds(5)));
                var innerExceptions = ((AggregateException)exception).InnerExceptions;
                Equal(1, innerExceptions.Count());
                IsType<SqlException>(innerExceptions.Single());
            }
        }

    }
}
