using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{    
    [Collection("Drapper.SqlServer.Execute")]    
    public class SqlServerExecute : Execute
    {
        public SqlServerExecute(SqlServerExecuteFixture serverFixture) : base(serverFixture)
        {            
        }
    }
}
