using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
