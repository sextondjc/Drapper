// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using static Drapper.Validation.Contract;

namespace Drapper
{
    /// <summary>
    /// Concrete implementation of the <see cref="IDbConnector"/>
    /// </summary>
    public class DbConnector : IDbConnector
    {   
        private readonly ISettings _settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbConnector"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public DbConnector(ISettings settings)
        {
            Require(settings != null, ErrorMessages.NullSettingsPassed);
            this._settings = settings;
        }

        /// <summary>
        /// Creates the database connection.
        /// </summary>
        /// <param name="type"></param>        
        public IDbConnection CreateDbConnection(Type type)
        {
            Require(type != null, ErrorMessages.NullTypeError);
            var connection = GetFromSettings(type);

            Require(connection != null, ErrorMessages.NullConnectionString, type.FullName);

            return CreateDbConnection(connection.ProviderName, connection.ConnectionString);
        }

        /// <summary>
        /// Creates a database connection.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="commandSetting"></param>
        /// <returns></returns>
        public IDbConnection CreateDbConnection(Type type, CommandSetting commandSetting)
        {
            var connection = commandSetting.ConnectionString;
            if(connection == null)
            {
                return CreateDbConnection(type);
            }

            return CreateDbConnection(connection.ProviderName, connection.ConnectionString);
        }

        /// <summary>
        /// Creates the database connection.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns></returns>
        private IDbConnection CreateDbConnection(string providerName, string connectionString)
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
        /// Gets from settings.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        private ConnectionStringSetting GetFromSettings(Type type)
        {
            var namespaceSetting = GetNamespaceSetting(type);
            Require(namespaceSetting != null, "NamespaceSetting not configured for {0}", type.FullName);

            // check if it has a definition.
            var typeSetting = namespaceSetting.Types?.SingleOrDefault(x => x.Name == type.FullName);

            if (typeSetting != null && typeSetting.ConnectionString != null)
            {
                return typeSetting.ConnectionString;
            }

            return namespaceSetting.ConnectionString;
        }

        /// <summary>
        /// Gets the namespace setting.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        private NamespaceSetting GetNamespaceSetting(Type type)
        {
            var result = _settings.Namespaces.SingleOrDefault(x => x.Namespace == type.Namespace);
            if (result != null)
            {
                return result;
            }

            // it ain't here. loop backwards till we find one that matches
            foreach (var setting in _settings.Namespaces.OrderByDescending(x=>x.Namespace.Length))
            {
                var @namespace = type.Namespace;
                var periods = @namespace.Count(x => x == '.');
                for (int i = periods; i > 0; i--)
                {
                    var entry = _settings.Namespaces.SingleOrDefault(x => x.Namespace == @namespace);
                    if (entry != null)
                    {
                        // we have a match. 
                        return entry;
                    }

                    @namespace = @namespace.Substring(0, @namespace.LastIndexOf('.'));
                }
            }

            return result;
        }

        #region / error messages /

        private static class ErrorMessages
        {
            internal const string NullConnectionString
                = "No connection string settings could be found for '{0}'. Please check configuration.";
            internal const string NullSettingsPassed
                = "The ISettings object passed to the constructor was null. ";
            internal const string NullTypeError
                = "The 'type' variable passed to CreateDbConnection was null.";
            internal const string NullConnectionStringName
                = "The connectionName passed to CreateDbConnection was null or empty.";
        }

        #endregion

    }
}
