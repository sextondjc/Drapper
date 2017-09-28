using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{    
    [Collection("Drapper.SqlServer.ExecuteAsync")]    
    public class SqlServerExecuteAsync : ExecuteAsync
    {
        public SqlServerExecuteAsync(SqlServerExecuteAsyncFixture serverFixture) : base(serverFixture)
        {            
        }
    }
}
