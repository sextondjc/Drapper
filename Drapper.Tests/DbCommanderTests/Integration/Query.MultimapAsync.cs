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
using static Drapper.Tests.Helpers.CommanderHelper;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoA>));
                IsTrue(result.Any());
                AreEqual(3, result.Count());

                // first record
                var first = result.First();
                AreEqual(6, first.Id);
                AreEqual("Multimap: 6", first.Name);
                AreEqual(20, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(1, pocoA.PocoA_Id);
                AreEqual("POCO A: 1", pocoA.Name);
                AreEqual(15, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithTwoParameters, new { Id = 5 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoA>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(10, first.Id);
                AreEqual("Multimap: 10", first.Name);
                AreEqual(24, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(5, pocoA.PocoA_Id);
                AreEqual("POCO A: 5", pocoA.Name);
                AreEqual(19, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithThreeParameters);
                
                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoB>));
                IsTrue(result.Any());
                AreEqual(3, result.Count());

                // first record
                var first = result.First();
                AreEqual(11, first.Id);
                AreEqual("Multimap: 11", first.Name);
                AreEqual(25, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(1, pocoA.PocoA_Id);
                AreEqual("POCO A: 1", pocoA.Name);
                AreEqual(15, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(6, pocoB.PocoB_Id);
                AreEqual("POCO B: 6", pocoB.Name);
                AreEqual(20, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithThreeParameters, new { Id = 5 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoB>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(15, first.Id);
                AreEqual("Multimap: 15", first.Name);
                AreEqual(29, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(5, pocoA.PocoA_Id);
                AreEqual("POCO A: 5", pocoA.Name);
                AreEqual(19, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(10, pocoB.PocoB_Id);
                AreEqual("POCO B: 10", pocoB.Name);
                AreEqual(24, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFourParameters);

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoC>));
                IsTrue(result.Any());
                AreEqual(3, result.Count());

                // first record
                var first = result.First();
                AreEqual(16, first.Id);
                AreEqual("Multimap: 16", first.Name);
                AreEqual(30, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(1, pocoA.PocoA_Id);
                AreEqual("POCO A: 1", pocoA.Name);
                AreEqual(15, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(6, pocoB.PocoB_Id);
                AreEqual("POCO B: 6", pocoB.Name);
                AreEqual(20, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(11, pocoC.PocoC_Id);
                AreEqual("POCO C: 11", pocoC.Name);
                AreEqual(25, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFourParameters, new { Id = 5 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoC>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(20, first.Id);
                AreEqual("Multimap: 20", first.Name);
                AreEqual(34, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(5, pocoA.PocoA_Id);
                AreEqual("POCO A: 5", pocoA.Name);
                AreEqual(19, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(10, pocoB.PocoB_Id);
                AreEqual("POCO B: 10", pocoB.Name);
                AreEqual(24, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(15, pocoC.PocoC_Id);
                AreEqual("POCO C: 15", pocoC.Name);
                AreEqual(29, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFiveParameters);

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoD>));
                IsTrue(result.Any());
                AreEqual(3, result.Count());

                // first record
                var first = result.First();
                AreEqual(21, first.Id);
                AreEqual("Multimap: 21", first.Name);
                AreEqual(35, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(1, pocoA.PocoA_Id);
                AreEqual("POCO A: 1", pocoA.Name);
                AreEqual(15, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(6, pocoB.PocoB_Id);
                AreEqual("POCO B: 6", pocoB.Name);
                AreEqual(20, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(11, pocoC.PocoC_Id);
                AreEqual("POCO C: 11", pocoC.Name);
                AreEqual(25, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(16, pocoD.PocoD_Id);
                AreEqual("POCO D: 16", pocoD.Name);
                AreEqual(30, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

            }
        }

        [TestMethod]
        public async Task WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithFiveParameters, new { Id = 5 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoD>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(25, first.Id);
                AreEqual("Multimap: 25", first.Name);
                AreEqual(39, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(5, pocoA.PocoA_Id);
                AreEqual("POCO A: 5", pocoA.Name);
                AreEqual(19, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(10, pocoB.PocoB_Id);
                AreEqual("POCO B: 10", pocoB.Name);
                AreEqual(24, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(15, pocoC.PocoC_Id);
                AreEqual("POCO C: 15", pocoC.Name);
                AreEqual(29, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(20, pocoD.PocoD_Id);
                AreEqual("POCO D: 20", pocoD.Name);
                AreEqual(34, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSixParameters);

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoE>));
                IsTrue(result.Any());
                AreEqual(3, result.Count());

                // first record
                var first = result.First();
                AreEqual(26, first.Id);
                AreEqual("Multimap: 26", first.Name);
                AreEqual(40, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(1, pocoA.PocoA_Id);
                AreEqual("POCO A: 1", pocoA.Name);
                AreEqual(15, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(6, pocoB.PocoB_Id);
                AreEqual("POCO B: 6", pocoB.Name);
                AreEqual(20, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(11, pocoC.PocoC_Id);
                AreEqual("POCO C: 11", pocoC.Name);
                AreEqual(25, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(16, pocoD.PocoD_Id);
                AreEqual("POCO D: 16", pocoD.Name);
                AreEqual(30, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                AreEqual(21, pocoE.PocoE_Id);
                AreEqual("POCO E: 21", pocoE.Name);
                AreEqual(35, pocoE.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSixParameters, new { Id = 5 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoE>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(30, first.Id);
                AreEqual("Multimap: 30", first.Name);
                AreEqual(44, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(5, pocoA.PocoA_Id);
                AreEqual("POCO A: 5", pocoA.Name);
                AreEqual(19, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(10, pocoB.PocoB_Id);
                AreEqual("POCO B: 10", pocoB.Name);
                AreEqual(24, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(15, pocoC.PocoC_Id);
                AreEqual("POCO C: 15", pocoC.Name);
                AreEqual(29, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(20, pocoD.PocoD_Id);
                AreEqual("POCO D: 20", pocoD.Name);
                AreEqual(34, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                AreEqual(25, pocoE.PocoE_Id);
                AreEqual("POCO E: 25", pocoE.Name);
                AreEqual(39, pocoE.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSevenParameters);

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoF>));
                IsTrue(result.Any());
                AreEqual(3, result.Count());

                // first record
                var first = result.First();
                AreEqual(31, first.Id);
                AreEqual("Multimap: 31", first.Name);
                AreEqual(45, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(1, pocoA.PocoA_Id);
                AreEqual("POCO A: 1", pocoA.Name);
                AreEqual(15, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(6, pocoB.PocoB_Id);
                AreEqual("POCO B: 6", pocoB.Name);
                AreEqual(20, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(11, pocoC.PocoC_Id);
                AreEqual("POCO C: 11", pocoC.Name);
                AreEqual(25, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(16, pocoD.PocoD_Id);
                AreEqual("POCO D: 16", pocoD.Name);
                AreEqual(30, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                AreEqual(21, pocoE.PocoE_Id);
                AreEqual("POCO E: 21", pocoE.Name);
                AreEqual(35, pocoE.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                AreEqual(26, pocoF.PocoF_Id);
                AreEqual("POCO F: 26", pocoF.Name);
                AreEqual(40, pocoF.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multimap.WithSevenParameters, new { Id = 5 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoF>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(35, first.Id);
                AreEqual("Multimap: 35", first.Name);
                AreEqual(49, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(5, pocoA.PocoA_Id);
                AreEqual("POCO A: 5", pocoA.Name);
                AreEqual(19, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(10, pocoB.PocoB_Id);
                AreEqual("POCO B: 10", pocoB.Name);
                AreEqual(24, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(15, pocoC.PocoC_Id);
                AreEqual("POCO C: 15", pocoC.Name);
                AreEqual(29, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(20, pocoD.PocoD_Id);
                AreEqual("POCO D: 20", pocoD.Name);
                AreEqual(34, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                AreEqual(25, pocoE.PocoE_Id);
                AreEqual("POCO E: 25", pocoE.Name);
                AreEqual(39, pocoE.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                AreEqual(30, pocoF.PocoF_Id);
                AreEqual("POCO F: 30", pocoF.Name);
                AreEqual(44, pocoF.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }

    }
}
