﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Drapper.Connectors.Databases.SqlServer;
using Drapper.Databases;
using Drapper.Readers.Databases;
using Drapper.Settings.Databases;
using Newtonsoft.Json;


namespace Drapper.Tests.Common
{
    public static class CommanderHelper
    {
        public static ICommander<T> UseSqlServer<T>(string settingsFile = "Drapper.Databases.Tests.SqlServer.json")
        {            
            var settings = JsonConvert.DeserializeObject<DatabaseCommanderSettings>(File.ReadAllText(settingsFile));
            var reader = new DatabaseCommandReader(settings);
            var connector = new SqlServerDatabaseConnector(settings);
            return new DatabaseCommander<T>(reader, connector);
        }        
    }
}
