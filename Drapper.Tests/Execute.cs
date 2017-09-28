//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:31)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Drapper.Tests.Models;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Transactions;
using Xunit;
using static Xunit.Assert;

// ReSharper disable ExplicitCallerInfoArgument

namespace Drapper.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract class Execute
    {
        protected Execute(ExecuteFixture serverFixture)
        {
            _commander = serverFixture.Commander;
        }

        private readonly ICommander<Execute> _commander;

        [Fact]
        public void EnlistingInAmbientTransactionsWithRequiredOptionNotSupported()
        {
            // damn. was hoping this would be supported :(
            var pocoA = new PocoA {Name = Guid.NewGuid().ToString(), Value = 1};
            var pocoB = new PocoB {Name = Guid.NewGuid().ToString(), Value = 2};

            var result = Throws<NotSupportedException>(() => _commander.Execute(() =>
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
        public void EnlistingInAmbientTransactionsWithRequiresNewOptionNotSupported()
        {
            // damn. was hoping this would be supported :(
            var pocoA = new PocoA {Name = Guid.NewGuid().ToString(), Value = 1};
            var pocoB = new PocoB {Name = Guid.NewGuid().ToString(), Value = 2};

            var result = Throws<NotSupportedException>(() => _commander.Execute(() =>
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
        public void ExceptionsAreReturnedToCaller()
        {
            var result = Throws<SqlException>(() => _commander.Execute(new {value = 1}));
            const string expected = "Divide by zero error encountered.\r\nThe statement has been terminated.";
            Equal(expected, result.Message);
        }

        [Fact]
        public void SupportParameterlessCalls()
        {
            var result = _commander.Execute<bool>();
            True(result);
        }

        [Fact]
        public void SupportsRollbackOnParameterlessCalls()
        {
            // get a count from [dbo].[Poco]
            // try to delete a record.
            //  throw exception
            // check count again. should match.

            var preCount = _commander.Query<int>(method: "SupportsRollbackOnParameterlessCalls.Count");
            var result = Throws<SqlException>(() => _commander.Execute<bool>());
            var postCount = _commander.Query<int>(method: "SupportsRollbackOnParameterlessCalls.Count");

            Equal("Divide by zero error encountered.", result.Message);
            Equal(preCount, postCount);
        }

        [Fact]
        public void SupportsSuppressedDistributedTransactions()
        {
            var pocoA = new PocoA {Name = Guid.NewGuid().ToString(), Value = 1};
            var pocoB = new PocoB {Name = Guid.NewGuid().ToString(), Value = 2};

            var record = _commander.Execute(() =>
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
        public void SupportsTransactionRollback()
        {
            var model = new PocoA {Name = Guid.NewGuid().ToString(), Value = int.MaxValue};

            var result = Throws<SqlException>(() => _commander.Execute(model));
            const string expected =
                "Arithmetic overflow error converting expression to data type float.\r\nThe statement has been terminated.";
            Equal(expected, result.Message);

            // check if the record has been rolled back.
            // ReSharper disable once ExplicitCallerInfoArgument
            var record = _commander.Query<PocoA>(new {model.Name}, method: "SupportsTransactionRollback.Query");
            NotNull(record);
            False(record.Any());
        }
    }
}