// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using static Drapper.Tests.Common.CommanderHelper;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class Multimap
    {
        [TestMethod]
        public void WithTwoTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithTwoParameters);
                                                
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
        public void WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithThreeParameters);

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
        public void WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFourParameters);

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
        public void WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFiveParameters);

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
        public void WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSixParameters);

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
        public void WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSevenParameters);

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
        public void WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithTwoParameters, new { Id = 8 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoA>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(13, first.Id);
                Assert.AreEqual("Multimap: 13", first.Name);
                Assert.AreEqual(27, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(8, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 8", pocoA.Name);
                Assert.AreEqual(22, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithThreeParameters, new { Id = 8 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoB>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(18, first.Id);
                Assert.AreEqual("Multimap: 18", first.Name);
                Assert.AreEqual(32, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(8, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 8", pocoA.Name);
                Assert.AreEqual(22, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(13, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 13", pocoB.Name);
                Assert.AreEqual(27, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFourParameters, new { Id = 8 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoC>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(23, first.Id);
                Assert.AreEqual("Multimap: 23", first.Name);
                Assert.AreEqual(37, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(8, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 8", pocoA.Name);
                Assert.AreEqual(22, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(13, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 13", pocoB.Name);
                Assert.AreEqual(27, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(18, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 18", pocoC.Name);
                Assert.AreEqual(32, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFiveParameters, new { Id = 8 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoD>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(28, first.Id);
                Assert.AreEqual("Multimap: 28", first.Name);
                Assert.AreEqual(42, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(8, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 8", pocoA.Name);
                Assert.AreEqual(22, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(13, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 13", pocoB.Name);
                Assert.AreEqual(27, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(18, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 18", pocoC.Name);
                Assert.AreEqual(32, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(23, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 23", pocoD.Name);
                Assert.AreEqual(37, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSixParameters, new { Id = 8 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoE>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(33, first.Id);
                Assert.AreEqual("Multimap: 33", first.Name);
                Assert.AreEqual(47, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(8, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 8", pocoA.Name);
                Assert.AreEqual(22, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(13, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 13", pocoB.Name);
                Assert.AreEqual(27, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(18, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 18", pocoC.Name);
                Assert.AreEqual(32, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(23, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 23", pocoD.Name);
                Assert.AreEqual(37, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Assert.AreEqual(28, pocoE.PocoE_Id);
                Assert.AreEqual("POCO E: 28", pocoE.Name);
                Assert.AreEqual(42, pocoE.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [TestMethod]
        public void WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSevenParameters, new { Id = 8 });

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoF>));
                Assert.IsTrue(result.Any());
                Assert.AreEqual(1, result.Count());

                // first record
                var first = result.First();
                Assert.AreEqual(38, first.Id);
                Assert.AreEqual("Multimap: 38", first.Name);
                Assert.AreEqual(52, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                Assert.AreEqual(8, pocoA.PocoA_Id);
                Assert.AreEqual("POCO A: 8", pocoA.Name);
                Assert.AreEqual(22, pocoA.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                Assert.AreEqual(13, pocoB.PocoB_Id);
                Assert.AreEqual("POCO B: 13", pocoB.Name);
                Assert.AreEqual(27, pocoB.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                Assert.AreEqual(18, pocoC.PocoC_Id);
                Assert.AreEqual("POCO C: 18", pocoC.Name);
                Assert.AreEqual(32, pocoC.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                Assert.AreEqual(23, pocoD.PocoD_Id);
                Assert.AreEqual("POCO D: 23", pocoD.Name);
                Assert.AreEqual(37, pocoD.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                Assert.AreEqual(28, pocoE.PocoE_Id);
                Assert.AreEqual("POCO E: 28", pocoE.Name);
                Assert.AreEqual(42, pocoE.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                Assert.AreEqual(33, pocoF.PocoF_Id);
                Assert.AreEqual("POCO F: 33", pocoF.Name);
                Assert.AreEqual(47, pocoF.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }
    }
}
