// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    public class NamespaceSettingElement : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        /// <value>
        /// The namespace.
        /// </value>
        [ConfigurationProperty("namespace", IsRequired = true)]
        public string Namespace => (string)base["namespace"];

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        [ConfigurationProperty("connectionString")]
        public ConnectionStringSettingElement ConnectionString => (ConnectionStringSettingElement)base["connectionString"];

        /// <summary>
        /// (Optional) Gets or sets the definitions base path. This setting allows 
        /// you to use separate query definition files per namespace. 
        /// </summary>        
        [ConfigurationProperty("path")]
        public PathSettingElement Path => ((PathSettingElement)(base["path"]));

        /// <summary>
        /// Gets or sets the type settings. This provides a more granular 
        /// configuration option at the type level.
        /// </summary>
        /// <value>
        /// The type settings.
        /// </value>
        [ConfigurationProperty("types")]
        public TypeSettingElementCollection Types => ((TypeSettingElementCollection)(base["types"]));
    }
}
