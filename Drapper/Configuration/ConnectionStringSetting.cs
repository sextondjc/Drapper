// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
namespace Drapper.Configuration
{
    /// <summary>
    /// Used so that we don't have to store connection strings in .config files.
    /// </summary>
    public class ConnectionStringSetting
    {
        /// <summary>
        /// Gets the name of the provider.
        /// </summary>
        /// <value>
        /// The name of the provider.
        /// </value>
        public string ProviderName { get; }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionStringSetting"/> class.
        /// </summary>
        /// <param name="providerName">Name of the provider.</param>
        /// <param name="connectionString">The connection string.</param>
        public ConnectionStringSetting(string providerName, string connectionString)
        {            
            this.ProviderName = providerName;
            this.ConnectionString = connectionString;
        }

    }
}
