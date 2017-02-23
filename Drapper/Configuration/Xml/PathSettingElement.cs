// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using System.Configuration;

namespace Drapper.Configuration.Xml
{
    public class PathSettingElement : ConfigurationElement
    {
        [ConfigurationProperty("directory")]
        public string Directory => (string)base["directory"];

        [ConfigurationProperty("file")]
        public string File => (string)base["file"];

        [ConfigurationProperty("extension")]
        public string Extension => (string)base["extension"];
    }
}
