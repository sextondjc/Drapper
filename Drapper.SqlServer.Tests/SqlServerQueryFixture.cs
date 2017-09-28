using Drapper.SqlServer.Tests.Setup;
using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerQueryFixture : QueryFixture
    {        
        public SqlServerQueryFixture(): base(CommanderHelper.UseSqlServer<Query>())
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}