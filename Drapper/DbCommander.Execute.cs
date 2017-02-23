// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using Dapper;
using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Drapper
{
    public sealed partial class DbCommander : IDbCommander
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public bool Execute(
            Type type = null,
            [CallerMemberName] string method = null)
        {
            // get the caller type if it hasn't been passed in. 
            type = type ?? GetCallerType();
            var definition = _reader.GetCommand(type, method);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(definition.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(definition, transaction: transaction);
                        var result = (connection.Execute(command) > 0);
                        transaction.Commit();
                        return result;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public bool Execute<T>(
            T model, 
            Type type = null, 
            [CallerMemberName] string method = null)
        {
            // get the caller type if it hasn't been passed in. 
            type = type ?? GetCallerType();
            var definition = _reader.GetCommand(type, method);            
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(definition.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(definition, model, transaction);
                        var result = (connection.Execute(command) > 0);
                        transaction.Commit();
                        return result;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public TResult Execute<TResult>(
            Func<TResult> map, 
            Type type = null, 
            [CallerMemberName] string method = null)
        {
            // thought: should we support passing in the transaction scope option?
            //          i.e. let it be overridden by query definition?
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
                var result = map();
                scope.Complete();
                return result;
            }
        }
    }
}
