using Xunit;

namespace Drapper.SqlServer.Tests
{
    [CollectionDefinition("Drapper.SqlServer.Query")]
    public class SqlServerQueryFixtureCollection : ICollectionFixture<SqlServerQueryFixture> { }
}