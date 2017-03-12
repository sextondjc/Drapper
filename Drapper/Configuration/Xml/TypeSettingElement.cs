// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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
