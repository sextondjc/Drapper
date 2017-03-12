// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Drapper.Configuration
{
    /// <summary>
    /// Provides more granular configuration options at the type level.
    /// </summary>
    public class TypeSetting
    {
        /// <summary>
        /// Gets or sets the type name.
        /// </summary>
        /// <value>
        /// The type name.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }        

        /// <summary>
        /// (Optional) Gets or sets the path settings. These paths
        /// can be used to control where definition files are stored.
        /// At the type level, this should be a path to a file.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PathSetting Path { get; set; }

        /// <summary>
        /// Gets or sets the connection string setting for this type.
        /// </summary>
        /// <value>
        /// The connection string setting.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ConnectionStringSetting ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the definitions for this type.
        /// </summary>
        /// <value>
        /// The definitions.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IDictionary<string, CommandSetting> Commands { get; set; }
    }
}
