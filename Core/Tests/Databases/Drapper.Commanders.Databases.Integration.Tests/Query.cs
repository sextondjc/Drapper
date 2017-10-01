//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Drapper.Tests.Models;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Commanders.Databases.Integration.Tests
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
            var result = ThrowsAny<Exception>(() => _commander.Query<int>());
            const string expected = "Divide by zero error encountered.";
            Equal(expected, result.Message);
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
            var result = _commander.Query<PocoA>(new {Id = 3}).ToList();
            NotNull(result);
            True(result.Any());
            Equal(1, result.Count());

            // check values 
            var first = result.First();
            Equal(3, first.PocoA_Id);
            Equal("A13", first.Name);
            Equal(17, first.Value);
        }
    }
}