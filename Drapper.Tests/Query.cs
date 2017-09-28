using Drapper.Tests.Models;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class Query
    {
        private readonly ICommander<Query> _commander;        

        protected Query(QueryFixture serverFixture)
        {            
            _commander = serverFixture.Commander;
        }

        [Fact]
        public void OneTypeWithNoParameters()
        {            
            var result = _commander.Query<PocoA>().ToList();
            NotNull(result);
            True(result.Any());
        }

        [Fact]
        public void OneTypeWithParameters()
        {
            var result = _commander.Query<PocoA>(new { Id = 3 }).ToList();
            NotNull(result);
            True(result.Any());
            Equal(1, result.Count());

            // check values 
            var first = result.First();
            Equal(3, first.PocoA_Id);
            Equal("A13", first.Name);
            Equal(17, first.Value);
        }
        
        [Fact]
        public void ExceptionsAreReturnedToCaller()
        {
            var result = Throws<SqlException>(() => _commander.Query<int>());
            const string expected = "Divide by zero error encountered.";
            Equal(expected, result.Message);
        }
    }
}
