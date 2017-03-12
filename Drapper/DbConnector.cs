// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:52)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using Drapper.Configuration;
using static Drapper.Validation.Contract;

#endregion

namespace Drapper
{
    /// <summary>
    ///     Concrete implementation of the <see cref="IDbConnector" />
    /// </summary>
    public class DbConnector : IDbConnector
    {
        private readonly ISettings _settings;
        private readonly CommandReaderUtilities _utilities;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DbConnector" /> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public DbConnector(ISettings settings)
        {
            Require<ArgumentNullException>(settings != null, ErrorMessages.NullSettingsPassed);
            _settings = settings;
            _utilities = new CommandReaderUtilities(_settings);
        }

        /// <summary>
        ///     Creates a database connection.
        /// </summary>
        /// <param name="type"></param>
        public IDbConnection CreateDbConnection(Type type)
        {
            Require<ArgumentNullException>(type != null, ErrorMessages.NullTypeError);
            var connection = GetFromSettings(type);

            Require<ArgumentNullException>(connection != null,
                    ErrorMessages.NullConnectionString,
                    type.FullName);

            return CreateDbConnection(connection.ProviderName, connection.ConnectionString);
        }

        /// <summary>
        ///     Creates a database connection.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="commandSetting"></param>
        /// <returns></returns>
        public IDbConnection CreateDbConnection(Type type, CommandSetting commandSetting)
        {
            var connectionString = commandSetting.ConnectionString;
            if (connectionString == null)
            {
                return CreateDbConnection(type);
            }            
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(connectionString.ProviderName), "The providerName from the command setting cannot be null.");
            Require<ArgumentNullException>(!string.IsNullOrWhiteSpace(connectionString.ConnectionString), "The connectionString from the command setting cannot be null.");

            return CreateDbConnection(connectionString.ProviderName, connectionString.ConnectionString);
        }

        /// <summary>
        ///     Creates the database connection.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        private IDbConnection CreateDbConnection(
            string providerName,
            string connectionString)
        {                                    
            // Assume failure.
            DbConnection connection = null;

            // Create the DbProviderFactory and DbConnection.
            if (connectionString != null)
            {
                try
                {
                    var factory =
                        DbProviderFactories.GetFactory(providerName);

                    connection = factory.CreateConnection();
                    connection.ConnectionString = connectionString;
                }
                catch
                {
                    // Set the connection to null if it was created.
                    if (connection != null)
                    {
                        connection = null;
                    }
                    throw;
                }
            }
            // Return the connection.
            return connection;
        }

        /// <summary>
        ///     Gets from settings.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        private ConnectionStringSetting GetFromSettings(Type type)
        {
            var namespaceSetting = _utilities.GetNamespaceSetting(type);
            Require<ArgumentNullException>(namespaceSetting != null,
                    "NamespaceSetting not configured for {0}",
                    type.FullName);

            // check if it has a definition.
            var typeSetting = namespaceSetting.Types?.SingleOrDefault(x => x.Name == type.FullName);
            
            if (typeSetting != null && typeSetting?.ConnectionString != null)
            {
                return typeSetting.ConnectionString;
            }

            return namespaceSetting.ConnectionString;
        }
        
        private static class ErrorMessages
        {
            internal const string NullConnectionString = "No connection string settings could be found for '{0}'. Please check configuration.";
            internal const string NullSettingsPassed = "The ISettings object passed to the constructor was null. ";
            internal const string NullTypeError = "The 'type' variable passed to CreateDbConnection was null.";
            internal const string NullConnectionStringName = "The connectionName passed to CreateDbConnection was null or empty.";
        }
    }
}