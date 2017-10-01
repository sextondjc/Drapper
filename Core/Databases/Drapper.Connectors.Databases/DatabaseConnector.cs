//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using Drapper.Settings.Databases;
using static Drapper.Validation.Contract;

namespace Drapper.Connectors.Databases
{
    public class DatabaseConnector : IDatabaseConnector
    {
        private readonly Func<DbProviderFactory> _providerPredicate;
        private readonly IDatabaseCommanderSettings _settings;

        public DatabaseConnector(
            IDatabaseCommanderSettings settings,
            Func<DbProviderFactory> providerPredicate
        )
        {
            Require<ArgumentNullException>(settings != null, nameof(settings));
            Require<ArgumentNullException>(providerPredicate != null, nameof(providerPredicate));

            _settings = settings;
            _providerPredicate = providerPredicate;
        }

        public IDbConnection CreateConnection(DatabaseCommandSetting commandSetting)
        {
            // pre-conditions. 
            Require<ArgumentNullException>(commandSetting != null, nameof(commandSetting));

            // get the connection string setting from the root connections. 
            var connectionStringSetting =
                _settings.Connections.SingleOrDefault(x => x.Alias == commandSetting.ConnectionAlias);
            Require<NullReferenceException>(connectionStringSetting != null, Messages.NoAliasedConnection,
                commandSetting.ConnectionAlias);

            // invoke the provider predicate to return a connection. 
            var connection = _providerPredicate.Invoke().CreateConnection();
            Require<NullReferenceException>(connection != null, Messages.NoConnectionCreated,
                commandSetting.ConnectionAlias);

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