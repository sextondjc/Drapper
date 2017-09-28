using Xunit;

namespace Drapper.SqlServer.Tests
{
    [CollectionDefinition("Drapper.SqlServer.QueryAsync")]
    public class SqlServerQueryAsyncFixtureCollection : ICollectionFixture<SqlServerQueryAsyncFixture> { }
}