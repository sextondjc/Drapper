using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using Drapper.Settings.Databases;
using Drapper.Validation;

namespace Drapper.Connectors.Databases
{
    public class DatabaseConnector : IDatabaseConnector
    {        
        private readonly IDatabaseCommanderSettings _settings;
        private readonly Func<DbProviderFactory> _providerPredicate;

        public DatabaseConnector(            
            IDatabaseCommanderSettings settings,
            Func<DbProviderFactory> providerPredicate
            )
        {            
            Contract.Require<ArgumentNullException>(settings != null, nameof(settings));
            Contract.Require<ArgumentNullException>(providerPredicate != null, nameof(providerPredicate));

            _settings = settings;
            _providerPredicate = providerPredicate;
        }
        
        public IDbConnection CreateConnection(DatabaseCommandSetting commandSetting)
        {
            // pre-conditions. 
            Contract.Require<ArgumentNullException>(commandSetting != null, nameof(commandSetting));            

            // get the connection string setting from the root connections. 
            var connectionStringSetting = _settings.Connections.SingleOrDefault(x => x.Alias == commandSetting.ConnectionAlias);
            Contract.Require<NullReferenceException>(connectionStringSetting != null, Messages.NoAliasedConnection, commandSetting.ConnectionAlias);

            // invoke the provider predicate to return a connection. 
            var connection = _providerPredicate.Invoke().CreateConnection();
            Contract.Require<NullReferenceException>(connection != null, Messages.NoConnectionCreated, commandSetting.ConnectionAlias);
            
            // assign the connection and return
            connection.ConnectionString = connectionStringSetting.ConnectionString;
            return connection;
        }

        private static class Messages
        {
            internal const string NoAliasedConnection =
                "There is no connection with the alias '{0}' in the settings. Please check settings.";

            internal const string NoConnectionCreated =
                "The provider predicate did not return a connection for the aliased connection '{0}'.";
        }
    }
}
