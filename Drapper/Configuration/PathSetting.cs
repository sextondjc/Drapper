// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Newtonsoft.Json;

namespace Drapper.Configuration
{
    public class PathSetting
    {
        /// <summary>
        /// Gets or sets the path to a directory where definitions can be found. 
        /// </summary>        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Directory { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets the extension to use when searching for a file. Defaults to json
        /// </summary>        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Extension { get; set; } = "json";
    }
}
