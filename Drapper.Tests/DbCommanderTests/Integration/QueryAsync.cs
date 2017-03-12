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
using static Drapper.Tests.Common.CommanderHelper;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class QueryAsync
    {
        [TestMethod]
        public async Task SupportsParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {
                var response = await commander.QueryAsync<PocoA>();
                var result = response.ToList();

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<PocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(5, result.Count());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public async Task ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                var response = await commander.QueryAsync<int>();
                var result = response.ToList();
            }
        }

        [TestMethod]
        public async Task SupportsParameterizedCalls()
        {
            var date = new DateTime(2016, 4, 24);
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync<PocoA>(new { modified = date });
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<PocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // check values 
                var first = result.First();
                Assert.AreEqual("Entry 1", first.Name);
                Assert.AreEqual(5.10M, first.Value);
                Assert.AreEqual(new DateTime(2016, 4, 24), first.Modified);
            }
        }

        //[TestMethod]
        //[ExpectedException(typeof(AggregateException))]
        public void SupportsCancellationToken()
        {
            // turns out cancellation toekn isn't actually supported here. 
            // hmph. why did I think it was?
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(3));

            using (var commander = CreateCommander())
            {
                var task = commander.QueryAsync<int>(cancellationToken: tokenSource.Token);
                try
                {
                    task.Wait(TimeSpan.FromSeconds(5));
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

    }
}
