// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
// =============================================================================================================================

#region

using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace Drapper.Configuration
{
    /// <summary>
    ///     Provides more granular configuration options at the type level.
    /// </summary>
    public class TypeSetting
    {
        /// <summary>
        ///     Gets or sets the type name.
        /// </summary>
        /// <value>
        ///     The type name.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///     (Optional) Gets or sets the path settings. These paths
        ///     can be used to control where definition files are stored.
        ///     At the type level, this should be a path to a file.
        /// </summary>
        /// <value>
        ///     The path.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PathSetting Path { get; set; }

        /// <summary>
        ///     Gets or sets the connection string setting for this type.
        /// </summary>
        /// <value>
        ///     The connection string setting.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ConnectionStringSetting ConnectionString { get; set; }

        /// <summary>
        ///     Gets or sets the definitions for this type.
        /// </summary>
        /// <value>
        ///     The definitions.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IDictionary<string, CommandSetting> Commands { get; set; }
    }
}