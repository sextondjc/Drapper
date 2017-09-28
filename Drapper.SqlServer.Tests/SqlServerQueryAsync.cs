using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{    
    [Collection("Drapper.SqlServer.QueryAsync")]    
    public class SqlServerQueryAsync : QueryAsync
    {
        public SqlServerQueryAsync(SqlServerQueryAsyncFixture serverFixture) : base(serverFixture)
        {            
        }
    }
}
