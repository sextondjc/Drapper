//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:39)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Commanders.Databases;
using Drapper.Connectors.Databases.MySql;
using Drapper.Connectors.Databases.SqlServer;
using Drapper.Readers.Databases;
using Drapper.Settings.Databases;
using Newtonsoft.Json;
using System.IO;


namespace Drapper.Tests.Common
{
    public static class CommanderHelper
    {
        public static ICommander<T> UseSqlServer<T>(
            string settingsFile = "Drapper.SqlServer.Integration.Tests.json")
        {
            var settings = JsonConvert.DeserializeObject<DatabaseCommanderSettings>(File.ReadAllText(settingsFile));
            var reader = new DatabaseCommandReader(settings);
            var connector = new SqlServerDatabaseConnector(settings);
            return new DatabaseCommander<T>(reader, connector);
        }

        public static ICommander<T> UseMySql<T>(string settingsFile = "Drapper.MySql.Integration.Tests.json")
        {
            var settings = JsonConvert.DeserializeObject<DatabaseCommanderSettings>(File.ReadAllText(settingsFile));
            var reader = new DatabaseCommandReader(settings);
            var connector = new MySqlDatabaseConnector(settings);
            return new DatabaseCommander<T>(reader, connector);
        }
    }
}