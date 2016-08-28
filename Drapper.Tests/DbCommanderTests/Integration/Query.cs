// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Drapper.Tests.Common.CommanderHelper;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class Query
    {
        [TestMethod]
        public void SupportsParameterlessCalls()
        {
            using (var commander = CreateCommander())
            {                
                var result = commander.Query<PocoA>();
                                
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<PocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(5, result.Count());

                // check values 
                var first = result.First();
                Assert.AreEqual(1, first.PocoA_Id);
                Assert.AreEqual("A11", first.Name);
                Assert.AreEqual(1, first.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, first.Modified.Date);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ExceptionsAreReturnedToCaller()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query<int>();
            }
        }

        [TestMethod]
        public void SupportsParameterizedCalls()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query<PocoA>(new { Id = 3 });
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<PocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // check values 
                var first = result.First();
                Assert.AreEqual(3, first.PocoA_Id);
                Assert.AreEqual("A13", first.Name);
                Assert.AreEqual(3, first.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, first.Modified.Date);
            }
        }
    }
}
