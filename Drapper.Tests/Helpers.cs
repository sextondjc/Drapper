// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Drapper.Configuration;
using Drapper.Configuration.Json;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Drapper.Tests.Common
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

    public static class TableHelper
    {
        public static void CreateTable(string tableName)
        {
            using(var commander = CommanderHelper.CreateCommander())
            {
                commander.Execute(new { tableName });
            }            
        } 
    }    
}
