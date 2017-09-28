//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (15:51)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Drapper.Tests.Models;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class QueryAsync
    {
        protected QueryAsync(QueryAsyncFixture serverFixture)
        {
            _commander = serverFixture.Commander;
        }

        private readonly ICommander<QueryAsync> _commander;

        [Fact]
        public async Task ExceptionsAreReturnedToCaller()
        {
            var result = await ThrowsAsync<SqlException>(() => _commander.QueryAsync<int>());
            var expected = "Divide by zero error encountered.";
            Equal(expected, result.Message);
        }

        [Fact]
        public async Task OneTypeWithNoParameters()
        {
            var result = await _commander.QueryAsync<PocoA>();
            NotNull(result);
            True(result.Any());
        }

        [Fact]
        public async Task OneTypeWithParameters()
        {
            var result = await _commander.QueryAsync<PocoA>(new {Id = 3});
            NotNull(result);
            True(result.Any());
            Equal(1, result.Count());

            // check values 
            var first = result.First();
            Equal(3, first.PocoA_Id);
            Equal("A13", first.Name);
            Equal(17, first.Value);
        }

        [Fact]
        public void SupportsCancellationToken()
        {
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(3));

            var task = _commander.QueryAsync<int>(cancellationToken: tokenSource.Token);
            var exception = Throws<AggregateException>(() => task.Wait(TimeSpan.FromSeconds(5)));
            var innerExceptions = exception.InnerExceptions;
            Equal(1, innerExceptions.Count);
            IsType<SqlException>(innerExceptions.Single());
            const string expected =
                "A severe error occurred on the current command.  The results, if any, should be discarded.\r\nOperation cancelled by user.";
            Equal(expected, innerExceptions.Single().Message);
        }
    }
}