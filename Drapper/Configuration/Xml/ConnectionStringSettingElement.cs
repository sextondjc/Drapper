// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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
