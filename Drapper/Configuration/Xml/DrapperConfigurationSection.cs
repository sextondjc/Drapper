// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System.Configuration;

namespace Drapper.Configuration.Xml
{
    public class DrapperConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("namespaces")]
        public NamespaceSettingElementCollection Namespaces => ((NamespaceSettingElementCollection)(base["namespaces"]));

        public static DrapperConfigurationSection GetConfiguration() => ConfigurationManager.GetSection("Drapper") as DrapperConfigurationSection;
    }
}
