// ============================================================================================================================= 
// author       : david sexton (@sextondjc | sextondjc.com)
// date         : 2015.12.23 (23:44)
// modified     : 2017-02-19 (22:58)
// licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
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
