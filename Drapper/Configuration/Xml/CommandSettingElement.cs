// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Dapper;
using System.Configuration;
using System.Data;

namespace Drapper.Configuration.Xml
{
    public class CommandSettingElement : ConfigurationElement
    {
        [ConfigurationProperty("split", IsRequired = false, DefaultValue = "Id")]
        public string Split => (string)base["split"];

        [ConfigurationProperty("commandText", IsRequired = true)]
        public string CommandText => (string)base["commandText"];

        [ConfigurationProperty("commandTimeout", DefaultValue = 30, IsRequired = false)]
        public int CommandTimeout => (int)base["commandTimeout"];

        [ConfigurationProperty("commandType", DefaultValue = CommandType.Text, IsRequired = false)]
        public CommandType CommandType => (CommandType)base["commandType"];

        [ConfigurationProperty("flags", DefaultValue = CommandFlags.None, IsRequired = false)]
        public CommandFlags Flags => (CommandFlags)base["flags"];

        [ConfigurationProperty("isolationLevel", DefaultValue = IsolationLevel.Serializable, IsRequired = false)]
        public IsolationLevel IsolationLevel => (IsolationLevel)base["isolationLevel"];

        [ConfigurationProperty("connectionString")]
        public ConnectionStringSettingElement ConnectionString => (ConnectionStringSettingElement)base["connectionString"];

        
    }
}
