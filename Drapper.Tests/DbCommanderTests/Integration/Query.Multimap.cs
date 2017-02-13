// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
        public void ComplexWithTwoParameters()
        {
            using(var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.ComplexWithTwoParameters2);

                IsNotNull(result);                
            }
        }
                
        [TestMethod]
        public void WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithThreeParameters);

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
        public void WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFourParameters);

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
        public void WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFiveParameters);

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
        public void WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSixParameters);

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
        public void WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSevenParameters);

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
        public void WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithTwoParameters, new { Id = 8 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoA>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(13, first.Id);
                AreEqual("Multimap: 13", first.Name);
                AreEqual(27, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(8, pocoA.PocoA_Id);
                AreEqual("POCO A: 8", pocoA.Name);
                AreEqual(22, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithThreeParameters, new { Id = 8 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoB>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(18, first.Id);
                AreEqual("Multimap: 18", first.Name);
                AreEqual(32, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(8, pocoA.PocoA_Id);
                AreEqual("POCO A: 8", pocoA.Name);
                AreEqual(22, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(13, pocoB.PocoB_Id);
                AreEqual("POCO B: 13", pocoB.Name);
                AreEqual(27, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFourParameters, new { Id = 8 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoC>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(23, first.Id);
                AreEqual("Multimap: 23", first.Name);
                AreEqual(37, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(8, pocoA.PocoA_Id);
                AreEqual("POCO A: 8", pocoA.Name);
                AreEqual(22, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(13, pocoB.PocoB_Id);
                AreEqual("POCO B: 13", pocoB.Name);
                AreEqual(27, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(18, pocoC.PocoC_Id);
                AreEqual("POCO C: 18", pocoC.Name);
                AreEqual(32, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithFiveParameters, new { Id = 8 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoD>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(28, first.Id);
                AreEqual("Multimap: 28", first.Name);
                AreEqual(42, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(8, pocoA.PocoA_Id);
                AreEqual("POCO A: 8", pocoA.Name);
                AreEqual(22, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(13, pocoB.PocoB_Id);
                AreEqual("POCO B: 13", pocoB.Name);
                AreEqual(27, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(18, pocoC.PocoC_Id);
                AreEqual("POCO C: 18", pocoC.Name);
                AreEqual(32, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(23, pocoD.PocoD_Id);
                AreEqual("POCO D: 23", pocoD.Name);
                AreEqual(37, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);
            }
        }
        
        [TestMethod]
        public void WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSixParameters, new { Id = 8 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoE>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(33, first.Id);
                AreEqual("Multimap: 33", first.Name);
                AreEqual(47, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(8, pocoA.PocoA_Id);
                AreEqual("POCO A: 8", pocoA.Name);
                AreEqual(22, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(13, pocoB.PocoB_Id);
                AreEqual("POCO B: 13", pocoB.Name);
                AreEqual(27, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(18, pocoC.PocoC_Id);
                AreEqual("POCO C: 18", pocoC.Name);
                AreEqual(32, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(23, pocoD.PocoD_Id);
                AreEqual("POCO D: 23", pocoD.Name);
                AreEqual(37, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                AreEqual(28, pocoE.PocoE_Id);
                AreEqual("POCO E: 28", pocoE.Name);
                AreEqual(42, pocoE.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);
            }
        }

        [TestMethod]
        public void WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = commander.Query(Map.Query.Multimap.WithSevenParameters, new { Id = 8 });

                IsNotNull(result);
                IsInstanceOfType(result, typeof(IEnumerable<MultiMapPocoF>));
                IsTrue(result.Any());
                AreEqual(1, result.Count());

                // first record
                var first = result.First();
                AreEqual(38, first.Id);
                AreEqual("Multimap: 38", first.Name);
                AreEqual(52, first.Value);

                // poco A:
                var pocoA = first.PocoA;
                AreEqual(8, pocoA.PocoA_Id);
                AreEqual("POCO A: 8", pocoA.Name);
                AreEqual(22, pocoA.Value);
                AreEqual(DateTime.UtcNow.Date, pocoA.Modified.Date);

                // poco B:
                var pocoB = first.PocoB;
                AreEqual(13, pocoB.PocoB_Id);
                AreEqual("POCO B: 13", pocoB.Name);
                AreEqual(27, pocoB.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, pocoB.Modified.Date);

                // poco C:
                var pocoC = first.PocoC;
                AreEqual(18, pocoC.PocoC_Id);
                AreEqual("POCO C: 18", pocoC.Name);
                AreEqual(32, pocoC.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, pocoC.Modified.Date);

                // poco D:
                var pocoD = first.PocoD;
                AreEqual(23, pocoD.PocoD_Id);
                AreEqual("POCO D: 23", pocoD.Name);
                AreEqual(37, pocoD.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, pocoD.Modified.Date);

                // poco E: 
                var pocoE = first.PocoE;
                AreEqual(28, pocoE.PocoE_Id);
                AreEqual("POCO E: 28", pocoE.Name);
                AreEqual(42, pocoE.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, pocoE.Modified.Date);

                // poco F:
                var pocoF = first.PocoF;
                AreEqual(33, pocoF.PocoF_Id);
                AreEqual("POCO F: 33", pocoF.Name);
                AreEqual(47, pocoF.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, pocoF.Modified.Date);
            }
        }
    }
}
