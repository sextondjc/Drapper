using Xunit;

namespace Drapper.SqlServer.Tests
{
    [CollectionDefinition("Drapper.SqlServer.ExecuteAsync")]
    public class SqlServerExecuteAsyncFixtureCollection : ICollectionFixture<SqlServerExecuteAsyncFixture> { }
}