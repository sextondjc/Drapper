// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Dapper;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Drapper
{
    public sealed partial class DbCommander : IDbCommander
    {
        public async Task<bool> ExecuteAsync<T>(
            T model, 
            Type type = null, 
            CancellationToken cancellationToken = default(CancellationToken), 
            [CallerMemberName] string method = null)
        {
            type = type ?? GetAsyncCallerType();
            var definition = _reader.GetCommand(type, method);
            using (var connection = _connector.CreateDbConnection(type, definition))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(definition.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(definition, model, transaction, cancellationToken);
                        var result = (await connection.ExecuteAsync(command) > 0);
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
        
        public async Task<TResult> ExecuteAsync<TResult>(
            Func<TResult> map, 
            CancellationToken cancellationToken = default(CancellationToken), 
            [CallerMemberName] string method = null)
        {
            // i'm honestly not lovin this method. looks like it could cause
            // too many holes and could lead to some seriously, serious
            // nasty, nasty.             
            using (var scope = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled))
            {
                // could also be abused as sync over async.
                // todo: write tests to prove abuse and write about 
                // why it's bad, bad, bad. 
                var result = await Task.FromResult(map());
                scope.Complete();
                return result;
            }
        }
    }
}
