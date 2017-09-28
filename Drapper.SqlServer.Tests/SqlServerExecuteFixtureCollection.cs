using Xunit;

namespace Drapper.SqlServer.Tests
{
    [CollectionDefinition("Drapper.SqlServer.Execute")]
    public class SqlServerExecuteFixtureCollection : ICollectionFixture<SqlServerExecuteFixture> { }
}