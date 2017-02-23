// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Drapper.Configuration
{
    /// <summary>
    /// Root configuration option for Drapper. 
    /// </summary>
    public class NamespaceSetting
    {
        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        /// <value>
        /// The namespace.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Namespace { get; set; }

        /// <summary>
        /// (Optional) Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ConnectionStringSetting ConnectionString { get; set; }
        
        /// <summary>
        /// (Optional) Gets or sets the path settings. These paths
        /// can be used to control where definition files are stored.
        /// At the namespace level, this should be a Directory path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PathSetting Path { get; set; }

        /// <summary>
        /// Gets or sets the type settings. This provides a more granular 
        /// configuration option at the type level.
        /// </summary>
        /// <value>
        /// The type settings.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<TypeSetting> Types { get; set; }
    }
}
