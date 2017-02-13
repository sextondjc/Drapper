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
using static Drapper.Tests.Helpers.CommanderHelper;
using static Drapper.Tests.Helpers.TableHelper;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
                                
                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<PocoA>));
                IsTrue(result.Any());
                AreEqual(5, result.Count());

                // check values 
                var first = result.First();
                AreEqual(1, first.PocoA_Id);
                AreEqual("A11", first.Name);
                AreEqual(1, first.Value);
                AreEqual(DateTime.UtcNow.Date, first.Modified.Date);
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
                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<PocoA>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // check values 
                var first = result.First();
                AreEqual(3, first.PocoA_Id);
                AreEqual("A13", first.Name);
                AreEqual(3, first.Value);
                AreEqual(DateTime.UtcNow.Date, first.Modified.Date);
            }
        }

        [TestMethod]
        public void ReturnsIdentity()
        {
            // not really an "execute" method, but:
            //  returning scope_identity is more of 
            //  "return" value (GET) than it is a 
            //  persistence operation. it's the 
            //  second half of a two part operation.
            const string tableName = "IdentityTest";
            CreateTable(tableName); 
            var model = new PocoA { Name = Guid.NewGuid().ToString(), Value = 1 };
            using (var commander = CreateCommander())
            {
                commander.Execute(() =>
                {
                    var result = commander.Query<int>(new { model.Name, model.Value }, typeof(Execute), "ReturnsIdentity");
                    AreEqual(1, result.Single());
                    result = commander.Query<int>(new { model.Name, model.Value }, typeof(Execute), "ReturnsIdentity");
                    AreEqual(2, result.Single());
                    result = commander.Query<int>(new { model.Name, model.Value }, typeof(Execute), "ReturnsIdentity");
                    AreEqual(3, result.Single());
                    return result;
                });
            }
        }
    }    
}
