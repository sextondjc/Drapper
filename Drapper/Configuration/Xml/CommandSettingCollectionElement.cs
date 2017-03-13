// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using System.Configuration;

namespace Drapper.Configuration.Xml
{
    public class CommandSettingCollectionElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => (string)base["name"];

        [ConfigurationProperty("commandSetting", IsRequired = true)]
        public CommandSettingElement CommandSetting => (CommandSettingElement)base["commandSetting"];
    }
}
