// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    public class ConnectionStringSettingElement : ConfigurationElement
    {
        [ConfigurationProperty("providerName", IsRequired = true)]
        public string ProviderName => (string)base["providerName"];

        [ConfigurationProperty("connectionString", IsRequired = true)]
        public string ConnectionString => (string)base["connectionString"];
    }
}
