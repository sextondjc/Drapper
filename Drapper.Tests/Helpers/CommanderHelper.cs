// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================

using System.IO;
using Drapper.Configuration;
using Drapper.Configuration.Json;
using Newtonsoft.Json;

namespace Drapper.Tests.Helpers
{
    /// <summary>
    ///  Utility class to save me from repetitve coding. 
    /// </summary>
    public static class CommanderHelper
    {
        public static IDbCommander CreateCommander()
        {            
            var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Drapper.Settings.json"));
            var reader = new JsonFileCommandReader(settings);            
            var connector = new DbConnector(settings);            
            var result = new DbCommander(connector, reader);
            return result;
        }
    }    
}
