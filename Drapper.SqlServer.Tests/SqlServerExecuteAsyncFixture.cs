using Drapper.SqlServer.Tests.Setup;
using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerExecuteAsyncFixture : ExecuteAsyncFixture
    {        
        public SqlServerExecuteAsyncFixture(): base(CommanderHelper.UseSqlServer<ExecuteAsync>())
        {
            var setup = new DatabaseSetup();
            setup.Setup();
        }
    }
}