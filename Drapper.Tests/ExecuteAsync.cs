//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (21:36)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Drapper.Tests.Models;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;
using static Xunit.Assert;

// ReSharper disable ExplicitCallerInfoArgument

namespace Drapper.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract class ExecuteAsync
    {
        protected ExecuteAsync(ExecuteAsyncFixture serverFixture)
        {
            _commander = serverFixture.Commander;
        }

        private readonly ICommander<ExecuteAsync> _commander;

        [Fact]
        public async Task EnlistingInAmbientTransactionsWithRequiredOptionNotSupported()
        {
            // damn. was hoping this would be supported :(
            var pocoA = new PocoA {Name = Guid.NewGuid().ToString(), Value = 1};
            var pocoB = new PocoB {Name = Guid.NewGuid().ToString(), Value = 2};

            var result = await ThrowsAsync<NotSupportedException>(() => _commander.ExecuteAsync(() =>
            {
                var t1 = _commander.Execute(pocoA) ? pocoA : null;
                var t2 = _commander.Execute(pocoB) ? pocoB : null;

                return new MultiMapPocoB
                {
                    PocoA = t1,
                    PocoB = t2
                };
            }, TransactionScopeOption.Required));

            Equal("Enlisting in Ambient transactions is not supported.", result.Message);
        }

        [Fact]
        public async Task EnlistingInAmbientTransactionsWithRequiresNewOptionNotSupported()
        {
            // damn. was hoping this would be supported :(
            var pocoA = new PocoA {Name = Guid.NewGuid().ToString(), Value = 1};
            var pocoB = new PocoB {Name = Guid.NewGuid().ToString(), Value = 2};

            var result = await ThrowsAsync<NotSupportedException>(() => _commander.ExecuteAsync(() =>
            {
                var t1 = _commander.Execute(pocoA) ? pocoA : null;
                var t2 = _commander.Execute(pocoB) ? pocoB : null;

                return new MultiMapPocoB
                {
                    PocoA = t1,
                    PocoB = t2
                };
            }, TransactionScopeOption.RequiresNew));

            Equal("Enlisting in Ambient transactions is not supported.", result.Message);
        }

        [Fact]
        public async Task ExceptionsAreReturnedToCaller()
        {
            var result = await ThrowsAsync<SqlException>(() => _commander.ExecuteAsync(new {value = 1}));
            const string expected = "Divide by zero error encountered.\r\nThe statement has been terminated.";
            Equal(expected, result.Message);
        }

        [Fact]
        public async Task SupportParameterlessCalls()
        {
            var result = await _commander.ExecuteAsync<bool>();
            True(result);
        }

        [Fact]
        public async Task SupportsRollbackOnParameterlessCalls()
        {
            // get a count from [dbo].[Poco]
            // try to delete a record.
            //  throw exception
            // check count again. should match.

            var preCount = await _commander.QueryAsync<int>(method: "SupportsRollbackOnParameterlessCalls.Count");
            var result = await ThrowsAsync<SqlException>(() => _commander.ExecuteAsync<bool>());
            var postCount = await _commander.QueryAsync<int>(method: "SupportsRollbackOnParameterlessCalls.Count");

            Equal("Divide by zero error encountered.", result.Message);
            Equal(preCount, postCount);
        }

        [Fact]
        public async Task SupportsSuppressedDistributedTransactions()
        {
            var pocoA = new PocoA {Name = Guid.NewGuid().ToString(), Value = 1};
            var pocoB = new PocoB {Name = Guid.NewGuid().ToString(), Value = 2};

            var record = await _commander.ExecuteAsync(() =>
            {
                var t1 = _commander.Execute(pocoA) ? pocoA : null;
                var t2 = _commander.Execute(pocoB) ? pocoB : null;

                return new MultiMapPocoB
                {
                    PocoA = t1,
                    PocoB = t2
                };
            });

            NotNull(record);
            NotNull(record.PocoA);
            NotNull(record.PocoB);

            Same(pocoB, record.PocoB);
        }

        [Fact]
        public async Task SupportsTransactionRollback()
        {
            var model = new PocoA {Name = Guid.NewGuid().ToString(), Value = int.MaxValue};

            var result = await ThrowsAsync<SqlException>(() => _commander.ExecuteAsync(model));
            const string expected =
                "Arithmetic overflow error converting expression to data type float.\r\nThe statement has been terminated.";
            Equal(expected, result.Message);

            // check if the record has been rolled back.
            // ReSharper disable once ExplicitCallerInfoArgument
            var record =
                await _commander.QueryAsync<PocoA>(new {model.Name}, method: "SupportsTransactionRollback.Query");
            NotNull(record);
            False(record.Any());
        }
    }
}