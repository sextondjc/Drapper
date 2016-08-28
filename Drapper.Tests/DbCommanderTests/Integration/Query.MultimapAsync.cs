// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Drapper.Tests.Common.CommanderHelper;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class MultimapAsync
    {
        [TestMethod]
        public async Task WithTwoTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithTwoParameters);

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(6, first.Id);
                Assert.AreEqual("Multimap: 6", first.Name);
                Assert.AreEqual(20, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(1, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 1", pocoA.Name);
                Assert.AreEqual(15, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithTwoParameters, new { Id = 5 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(10, first.Id);
                Assert.AreEqual("Multimap: 10", first.Name);
                Assert.AreEqual(24, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(5, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 5", pocoA.Name);
                Assert.AreEqual(19, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithThreeParameters);
                
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoB>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(11, first.Id);
                Assert.AreEqual("Multimap: 11", first.Name);
                Assert.AreEqual(25, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(1, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 1", pocoA.Name);
                Assert.AreEqual(15, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(6, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 6", pocoB.Name);
                Assert.AreEqual(20, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithThreeParameters, new { Id = 5 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoB>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(15, first.Id);
                Assert.AreEqual("Multimap: 15", first.Name);
                Assert.AreEqual(29, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(5, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 5", pocoA.Name);
                Assert.AreEqual(19, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(10, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 10", pocoB.Name);
                Assert.AreEqual(24, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFourParameters);

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoC>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(16, first.Id);
                Assert.AreEqual("Multimap: 16", first.Name);
                Assert.AreEqual(30, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(1, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 1", pocoA.Name);
                Assert.AreEqual(15, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(6, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 6", pocoB.Name);
                Assert.AreEqual(20, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(11, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 11", pocoC.Name);
                Assert.AreEqual(25, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFourParameters, new { Id = 5 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoC>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(20, first.Id);
                Assert.AreEqual("Multimap: 20", first.Name);
                Assert.AreEqual(34, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(5, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 5", pocoA.Name);
                Assert.AreEqual(19, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(10, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 10", pocoB.Name);
                Assert.AreEqual(24, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(15, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 15", pocoC.Name);
                Assert.AreEqual(29, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFiveParameters);

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoD>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(21, first.Id);
                Assert.AreEqual("Multimap: 21", first.Name);
                Assert.AreEqual(35, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(1, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 1", pocoA.Name);
                Assert.AreEqual(15, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(6, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 6", pocoB.Name);
                Assert.AreEqual(20, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(11, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 11", pocoC.Name);
                Assert.AreEqual(25, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(16, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 16", pocoD.Name);
                Assert.AreEqual(30, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

            }
        }

        [TestMethod]
        public async Task WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFiveParameters, new { Id = 5 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoD>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(25, first.Id);
                Assert.AreEqual("Multimap: 25", first.Name);
                Assert.AreEqual(39, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(5, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 5", pocoA.Name);
                Assert.AreEqual(19, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(10, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 10", pocoB.Name);
                Assert.AreEqual(24, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(15, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 15", pocoC.Name);
                Assert.AreEqual(29, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(20, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 20", pocoD.Name);
                Assert.AreEqual(34, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSixParameters);

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoE>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(26, first.Id);
                Assert.AreEqual("Multimap: 26", first.Name);
                Assert.AreEqual(40, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(1, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 1", pocoA.Name);
                Assert.AreEqual(15, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(6, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 6", pocoB.Name);
                Assert.AreEqual(20, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(11, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 11", pocoC.Name);
                Assert.AreEqual(25, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(16, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 16", pocoD.Name);
                Assert.AreEqual(30, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Assert.AreEqual(21, pocoE.PocoE_Id);
                Assert.AreEqual("POCO E: 21", pocoE.Name);
                Assert.AreEqual(35, pocoE.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSixParameters, new { Id = 5 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoE>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(30, first.Id);
                Assert.AreEqual("Multimap: 30", first.Name);
                Assert.AreEqual(44, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(5, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 5", pocoA.Name);
                Assert.AreEqual(19, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(10, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 10", pocoB.Name);
                Assert.AreEqual(24, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(15, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 15", pocoC.Name);
                Assert.AreEqual(29, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(20, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 20", pocoD.Name);
                Assert.AreEqual(34, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Assert.AreEqual(25, pocoE.PocoE_Id);
                Assert.AreEqual("POCO E: 25", pocoE.Name);
                Assert.AreEqual(39, pocoE.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSevenParameters);

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoF>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(3, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(31, first.Id);
                Assert.AreEqual("Multimap: 31", first.Name);
                Assert.AreEqual(45, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(1, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 1", pocoA.Name);
                Assert.AreEqual(15, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(6, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 6", pocoB.Name);
                Assert.AreEqual(20, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(11, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 11", pocoC.Name);
                Assert.AreEqual(25, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(16, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 16", pocoD.Name);
                Assert.AreEqual(30, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Assert.AreEqual(21, pocoE.PocoE_Id);
                Assert.AreEqual("POCO E: 21", pocoE.Name);
                Assert.AreEqual(35, pocoE.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                Assert.AreEqual(26, pocoF.PocoF_Id);
                Assert.AreEqual("POCO F: 26", pocoF.Name);
                Assert.AreEqual(40, pocoF.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSevenParameters, new { Id = 5 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoF>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(35, first.Id);
                Assert.AreEqual("Multimap: 35", first.Name);
                Assert.AreEqual(49, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(5, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 5", pocoA.Name);
                Assert.AreEqual(19, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(10, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 10", pocoB.Name);
                Assert.AreEqual(24, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(15, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 15", pocoC.Name);
                Assert.AreEqual(29, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(20, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 20", pocoD.Name);
                Assert.AreEqual(34, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Assert.AreEqual(25, pocoE.PocoE_Id);
                Assert.AreEqual("POCO E: 25", pocoE.Name);
                Assert.AreEqual(39, pocoE.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                Assert.AreEqual(30, pocoF.PocoF_Id);
                Assert.AreEqual("POCO F: 30", pocoF.Name);
                Assert.AreEqual(44, pocoF.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }

    }
}
