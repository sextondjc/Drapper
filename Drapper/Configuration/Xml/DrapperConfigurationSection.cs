// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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
