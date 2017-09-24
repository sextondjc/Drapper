using System.Data.SqlClient;
using Drapper.Settings.Databases;

namespace Drapper.Connectors.Databases.SqlServer
{
    public class SqlServerDatabaseConnector : DatabaseConnector
    {
        public SqlServerDatabaseConnector(IDatabaseCommanderSettings settings)
            :base(settings, () => SqlClientFactory.Instance) { }
    }
}
