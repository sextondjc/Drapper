using System;
using System.Runtime.CompilerServices;
using System.Transactions;
using Dapper;

namespace Drapper.Databases
{
    public partial class DatabaseCommander<TRepository>
    {
        public bool Execute<TResult>([CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            using (var connection = _connector.CreateConnection(setting))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(setting.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(setting, transaction: transaction);
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

        public bool Execute<TResult>(TResult model, [CallerMemberName] string method = null)
        {
            var setting = _reader.GetCommand(typeof(TRepository), method);
            using (var connection = _connector.CreateConnection(setting))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(setting.IsolationLevel))
                {
                    try
                    {
                        var command = GetCommandDefinition(setting, model, transaction);
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
        
        public TResult Execute<TResult>(Func<TResult> map, TransactionScopeOption scopeOption = TransactionScopeOption.Suppress, [CallerMemberName] string method = null)
        {            
            // thought: should we support passing in the transaction scope option?
            //          i.e. let it be overridden by query definition?
            using (var scope = new TransactionScope(scopeOption))
            {
                var result = map();
                scope.Complete();
                return result;
            }
        }
    }
}
