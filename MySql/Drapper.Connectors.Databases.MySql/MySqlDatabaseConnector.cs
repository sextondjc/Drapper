using System.Data.SqlClient;
using Drapper.Settings.Databases;

namespace Drapper.Connectors.Databases.MySql
{
    public class MySqlDatabaseConnector : DatabaseConnector
    {
        public MySqlDatabaseConnector(IDatabaseCommanderSettings settings) 
            : base(settings, () => SqlClientFactory.Instance)
        {
        }
    }
}
