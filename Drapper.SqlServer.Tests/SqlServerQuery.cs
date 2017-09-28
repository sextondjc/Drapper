using Drapper.Tests;
using Xunit;

namespace Drapper.SqlServer.Tests
{    
    [Collection("Drapper.SqlServer.Query")]    
    public class SqlServerQuery : Query
    {
        public SqlServerQuery(SqlServerQueryFixture serverFixture) : base(serverFixture)
        {            
        }
    }
}
