using Drapper.SqlServer.Tests.Setup;
using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerExecuteFixture : ExecuteFixture
    {        
        public SqlServerExecuteFixture(): base(CommanderHelper.UseSqlServer<Execute>())
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}