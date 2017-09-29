//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (00:35)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Drapper.Tests.Models;
using Xunit;

namespace Drapper.Databases.Integration.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class Query
    {
        protected Query(QueryFixture serverFixture)
        {
            _commander = serverFixture.Commander;
        }

        private readonly ICommander<Query> _commander;

        [Fact]
        public void ExceptionsAreReturnedToCaller()
        {
            var result = Assert.Throws<SqlException>(() => _commander.Query<int>());
            const string expected = "Divide by zero error encountered.";
            Assert.Equal(expected, result.Message);
        }

        [Fact]
        public void OneTypeWithNoParameters()
        {
            var result = _commander.Query<PocoA>().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
        }

        [Fact]
        public void OneTypeWithParameters()
        {
            var result = _commander.Query<PocoA>(new {Id = 3}).ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count());

            // check values 
            var first = result.First();
            Assert.Equal(3, first.PocoA_Id);
            Assert.Equal("A13", first.Name);
            Assert.Equal(17, first.Value);
        }
    }
}