// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    public class TypeSettingElement : ConfigurationElement
    {
        [ConfigurationProperty ("name", IsRequired = true)]
        public string Name => (string)base["name"];

        [ConfigurationProperty("path")]
        public PathSettingElement Path => ((PathSettingElement)(base["path"]));

        [ConfigurationProperty("connectionString")]
        public ConnectionStringSettingElement ConnectionString => ((ConnectionStringSettingElement)(base["connectionString"]));

        [ConfigurationProperty("commands")]
        public CommandSettingElementCollection Methods => ((CommandSettingElementCollection)(base["commands"]));
    }
}
