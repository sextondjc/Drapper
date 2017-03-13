// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using Drapper.Validation;

#endregion

namespace Drapper
{
    public sealed partial class DbCommander : IDbCommander
    {
        
        public async Task<bool> ExecuteAsync(
            Type type,
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {
            // type is required. 
            Contract.Require<ArgumentNullException>(type != null, "A type argument must be supplied to an asynchronus method. Failure in method '{0}'", method);
            var setting = _reader.GetCommand(type, method);
            using (var connection = _connector.CreateDbConnection(type, setting))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(setting.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(setting, transaction: transaction, cancellationToken: cancellationToken);
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
        
        public async Task<bool> ExecuteAsync<T>(
            T model,
            Type type, 
            CancellationToken cancellationToken = default(CancellationToken),
            [CallerMemberName] string method = null)
        {            
            Contract.Require<ArgumentNullException>(type != null, "A type argument must be supplied to an asynchronus method. Failure in method '{0}'", method);
            var setting = _reader.GetCommand(type, method);
            using (var connection = _connector.CreateDbConnection(type, setting))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(setting.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(setting, model, transaction, cancellationToken);
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