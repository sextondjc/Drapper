using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Drapper.Connectors.Databases.SqlServer;
using Drapper.Databases;
using Drapper.Readers.Databases;
using Drapper.Settings.Databases;

namespace Drapper.SqlServer
{
    public static class Extensions
    {
        public static ICommander<T> UseSqlServer<T>(IDatabaseCommanderSettings settings)
        {            
            var reader = new DatabaseCommandReader(settings);
            var connector = new SqlServerDatabaseConnector(settings);
            return new DatabaseCommander<T>(reader, connector);
        }
    }
}
