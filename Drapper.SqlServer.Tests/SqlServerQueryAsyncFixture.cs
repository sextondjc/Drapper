using Drapper.Tests;
using Drapper.Tests.Common;

namespace Drapper.SqlServer.Tests
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SqlServerQueryAsyncFixture : QueryAsyncFixture
    {        
        public SqlServerQueryAsyncFixture(): base(CommanderHelper.UseSqlServer<QueryAsync>())
        {
            
        }
    }
}