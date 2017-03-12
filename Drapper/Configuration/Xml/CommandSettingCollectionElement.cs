// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
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
