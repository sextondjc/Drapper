// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Drapper.Tests.Helpers.CommanderHelper;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [TestClass]
    public class MultipleAsync
    {
        [TestMethod]
        public async Task WithOneType()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithOneType);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A11", a1.Name);
                AreEqual(1, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwoTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwoTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A21", a1.Name);
                AreEqual(3, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B22", b1.Name); // rock lobstaaa! 
                AreEqual(8, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThreeTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A31", a1.Name);
                AreEqual(4, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B32", b1.Name); // rock lobstaaa! 
                AreEqual(10, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C34", c1.Name);
                AreEqual(21, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A41", a1.Name);
                AreEqual(5, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B42", b1.Name); // rock lobstaaa! 
                AreEqual(12, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C44", c1.Name);
                AreEqual(24, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D47", d1.Name);
                AreEqual(44, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFiveTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A51", a1.Name);
                AreEqual(6, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B52", b1.Name); // rock lobstaaa! 
                AreEqual(14, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C54", c1.Name);
                AreEqual(27, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D57", d1.Name);
                AreEqual(48, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E511", e1.Name);
                AreEqual(80, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A61", a1.Name);
                AreEqual(7, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B62", b1.Name);
                AreEqual(16, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C64", c1.Name);
                AreEqual(30, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D67", d1.Name);
                AreEqual(52, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E611", e1.Name);
                AreEqual(85, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F616", f1.Name);
                AreEqual(132, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSevenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A71", a1.Name);
                AreEqual(8, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B72", b1.Name);
                AreEqual(18, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C74", c1.Name);
                AreEqual(33, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D77", d1.Name);
                AreEqual(56, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E711", e1.Name);
                AreEqual(90, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F716", f1.Name);
                AreEqual(138, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G722", g1.Name);
                AreEqual(203, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithEightTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithEightTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A81", a1.Name);
                AreEqual(9, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B82", b1.Name);
                AreEqual(20, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C84", c1.Name);
                AreEqual(36, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D87", d1.Name);
                AreEqual(60, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E811", e1.Name);
                AreEqual(95, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F816", f1.Name);
                AreEqual(144, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G822", g1.Name);
                AreEqual(210, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H829", h1.Name);
                AreEqual(296, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithNineTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithNineTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A91", a1.Name);
                AreEqual(10, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B92", b1.Name);
                AreEqual(22, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C94", c1.Name);
                AreEqual(39, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D97", d1.Name);
                AreEqual(64, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E911", e1.Name);
                AreEqual(100, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F916", f1.Name);
                AreEqual(150, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G922", g1.Name);
                AreEqual(217, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H929", h1.Name);
                AreEqual(304, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I937", i1.Name);
                AreEqual(414, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A101", a1.Name);
                AreEqual(11, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B102", b1.Name);
                AreEqual(24, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C104", c1.Name);
                AreEqual(42, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D107", d1.Name);
                AreEqual(68, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1011", e1.Name);
                AreEqual(105, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1016", f1.Name);
                AreEqual(156, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1022", g1.Name);
                AreEqual(224, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1029", h1.Name);
                AreEqual(312, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1037", i1.Name);
                AreEqual(423, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1046", j1.Name);
                AreEqual(504, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithElevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithElevenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A111", a1.Name);
                AreEqual(12, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B112", b1.Name);
                AreEqual(26, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C114", c1.Name);
                AreEqual(45, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D117", d1.Name);
                AreEqual(72, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1111", e1.Name);
                AreEqual(110, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1116", f1.Name);
                AreEqual(162, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1122", g1.Name);
                AreEqual(231, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1129", h1.Name);
                AreEqual(320, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1137", i1.Name);
                AreEqual(432, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1146", j1.Name);
                AreEqual(513, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1156", k1.Name);
                AreEqual(737, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwelveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A121", a1.Name);
                AreEqual(13, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B122", b1.Name);
                AreEqual(28, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C124", c1.Name);
                AreEqual(48, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D127", d1.Name);
                AreEqual(76, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1211", e1.Name);
                AreEqual(115, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1216", f1.Name);
                AreEqual(168, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1222", g1.Name);
                AreEqual(238, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1229", h1.Name);
                AreEqual(328, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1237", i1.Name);
                AreEqual(441, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1246", j1.Name);
                AreEqual(522, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1256", k1.Name);
                AreEqual(748, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1267", l1.Name);
                AreEqual(948, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThirteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A131", a1.Name);
                AreEqual(14, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B132", b1.Name);
                AreEqual(30, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C134", c1.Name);
                AreEqual(51, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D137", d1.Name);
                AreEqual(80, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1311", e1.Name);
                AreEqual(120, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1316", f1.Name);
                AreEqual(174, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1322", g1.Name);
                AreEqual(245, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1329", h1.Name);
                AreEqual(336, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1337", i1.Name); // yes. yes, i am. (boom!)
                AreEqual(450, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1346", j1.Name);
                AreEqual(531, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1356", k1.Name);
                AreEqual(759, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1367", l1.Name);
                AreEqual(960, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1379", m1.Name);
                AreEqual(1196, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A141", a1.Name);
                AreEqual(15, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B142", b1.Name);
                AreEqual(32, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C144", c1.Name);
                AreEqual(54, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D147", d1.Name);
                AreEqual(84, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1411", e1.Name);
                AreEqual(125, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1416", f1.Name);
                AreEqual(180, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1422", g1.Name);
                AreEqual(252, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1429", h1.Name);
                AreEqual(344, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1437", i1.Name);
                AreEqual(459, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1446", j1.Name);
                AreEqual(540, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1456", k1.Name);
                AreEqual(770, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1467", l1.Name);
                AreEqual(972, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1479", m1.Name);
                AreEqual(1209, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                IsNotNull(collectionN);
                IsTrue(collectionN.Any());
                AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                IsNotNull(n1);
                AreEqual(92, n1.PocoN_Id);
                AreEqual("N1492", n1.Name);
                AreEqual(1484, n1.Value);
                AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFifteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A151", a1.Name);
                AreEqual(16, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B152", b1.Name);
                AreEqual(34, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C154", c1.Name);
                AreEqual(57, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D157", d1.Name);
                AreEqual(88, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1511", e1.Name);
                AreEqual(130, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1516", f1.Name);
                AreEqual(186, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1522", g1.Name);
                AreEqual(259, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1529", h1.Name);
                AreEqual(352, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1537", i1.Name);
                AreEqual(468, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1546", j1.Name);
                AreEqual(549, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1556", k1.Name);
                AreEqual(781, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1567", l1.Name);
                AreEqual(984, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1579", m1.Name);
                AreEqual(1222, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                IsNotNull(collectionN);
                IsTrue(collectionN.Any());
                AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                IsNotNull(n1);
                AreEqual(92, n1.PocoN_Id);
                AreEqual("N1592", n1.Name);
                AreEqual(1498, n1.Value);
                AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                IsNotNull(collectionO);
                IsTrue(collectionO.Any());
                AreEqual(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                IsNotNull(o1);
                AreEqual(106, o1.PocoO_Id);
                AreEqual("O15106", o1.Name);
                AreEqual(1815, o1.Value);
                AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes);

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A161", a1.Name);
                AreEqual(17, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B162", b1.Name);
                AreEqual(36, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C164", c1.Name);
                AreEqual(60, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D167", d1.Name);
                AreEqual(92, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1611", e1.Name);
                AreEqual(135, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1616", f1.Name);
                AreEqual(192, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1622", g1.Name);
                AreEqual(266, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1629", h1.Name);
                AreEqual(360, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1637", i1.Name);
                AreEqual(477, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1646", j1.Name);
                AreEqual(558, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1656", k1.Name);
                AreEqual(792, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1667", l1.Name);
                AreEqual(996, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1679", m1.Name);
                AreEqual(1235, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                IsNotNull(collectionN);
                IsTrue(collectionN.Any());
                AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                IsNotNull(n1);
                AreEqual(92, n1.PocoN_Id);
                AreEqual("N1692", n1.Name);
                AreEqual(1512, n1.Value);
                AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                IsNotNull(collectionO);
                IsTrue(collectionO.Any());
                AreEqual(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                IsNotNull(o1);
                AreEqual(106, o1.PocoO_Id);
                AreEqual("O16106", o1.Name);
                AreEqual(1830, o1.Value);
                AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);

                // collectionP
                IsNotNull(record.CollectionP);
                var collectionP = record.CollectionP;
                IsNotNull(collectionP);
                IsTrue(collectionP.Any());
                AreEqual(16, collectionP.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var p1 = collectionP.First();
                IsNotNull(p1);
                AreEqual(121, p1.PocoP_Id);
                AreEqual("P16121", p1.Name);
                AreEqual(2329, p1.Value);
                AreEqual(DateTime.UtcNow.AddDays(15).Date, p1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithOneTypeAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithOneType, new { Id = 1 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A11", a1.Name);
                AreEqual(1, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwoTypes, new { Id = 3 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A21", a1.Name);
                AreEqual(3, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(1, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(3, b1.PocoB_Id);
                AreEqual("B23", b1.Name); // rock lobstaaa! 
                AreEqual(10, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThreeTypes, new { Id = 6 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A31", a1.Name);
                AreEqual(4, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B32", b1.Name); // rock lobstaaa! 
                AreEqual(10, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(1, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(6, c1.PocoC_Id);
                AreEqual("C36", c1.Name);
                AreEqual(27, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourTypes, new { Id = 10 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A41", a1.Name);
                AreEqual(5, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B42", b1.Name); // rock lobstaaa! 
                AreEqual(12, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C44", c1.Name);
                AreEqual(24, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(1, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(10, d1.PocoD_Id);
                AreEqual("D410", d1.Name);
                AreEqual(56, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFiveTypes, new { Id = 15 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A51", a1.Name);
                AreEqual(6, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B52", b1.Name); // rock lobstaaa! 
                AreEqual(14, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C54", c1.Name);
                AreEqual(27, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D57", d1.Name);
                AreEqual(48, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(1, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(15, e1.PocoE_Id);
                AreEqual("E515", e1.Name);
                AreEqual(100, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixTypes, new { Id = 21 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A61", a1.Name);
                AreEqual(7, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B62", b1.Name);
                AreEqual(16, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C64", c1.Name);
                AreEqual(30, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D67", d1.Name);
                AreEqual(52, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E611", e1.Name);
                AreEqual(85, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(1, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(21, f1.PocoF_Id);
                AreEqual("F621", f1.Name);
                AreEqual(162, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSevenTypes, new { Id = 28 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A71", a1.Name);
                AreEqual(8, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B72", b1.Name);
                AreEqual(18, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C74", c1.Name);
                AreEqual(33, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D77", d1.Name);
                AreEqual(56, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E711", e1.Name);
                AreEqual(90, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F716", f1.Name);
                AreEqual(138, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(1, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(28, g1.PocoG_Id);
                AreEqual("G728", g1.Name);
                AreEqual(245, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithEightTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithEightTypes, new { Id = 36 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A81", a1.Name);
                AreEqual(9, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B82", b1.Name);
                AreEqual(20, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C84", c1.Name);
                AreEqual(36, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D87", d1.Name);
                AreEqual(60, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E811", e1.Name);
                AreEqual(95, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F816", f1.Name);
                AreEqual(144, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G822", g1.Name);
                AreEqual(210, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(1, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(36, h1.PocoH_Id);
                AreEqual("H836", h1.Name);
                AreEqual(352, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithNineTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithNineTypes, new { Id = 45 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A91", a1.Name);
                AreEqual(10, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B92", b1.Name);
                AreEqual(22, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C94", c1.Name);
                AreEqual(39, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D97", d1.Name);
                AreEqual(64, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E911", e1.Name);
                AreEqual(100, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F916", f1.Name);
                AreEqual(150, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G922", g1.Name);
                AreEqual(217, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H929", h1.Name);
                AreEqual(304, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(1, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(45, i1.PocoI_Id);
                AreEqual("I945", i1.Name);
                AreEqual(486, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTenTypes, new { Id = 55 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A101", a1.Name);
                AreEqual(11, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B102", b1.Name);
                AreEqual(24, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C104", c1.Name);
                AreEqual(42, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D107", d1.Name);
                AreEqual(68, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1011", e1.Name);
                AreEqual(105, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1016", f1.Name);
                AreEqual(156, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1022", g1.Name);
                AreEqual(224, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1029", h1.Name);
                AreEqual(312, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1037", i1.Name);
                AreEqual(423, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(1, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(55, j1.PocoJ_Id);
                AreEqual("J1055", j1.Name);
                AreEqual(585, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithElevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithElevenTypes, new { Id = 66 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A111", a1.Name);
                AreEqual(12, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B112", b1.Name);
                AreEqual(26, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C114", c1.Name);
                AreEqual(45, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D117", d1.Name);
                AreEqual(72, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1111", e1.Name);
                AreEqual(110, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1116", f1.Name);
                AreEqual(162, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1122", g1.Name);
                AreEqual(231, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1129", h1.Name);
                AreEqual(320, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1137", i1.Name);
                AreEqual(432, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1146", j1.Name);
                AreEqual(513, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(1, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(66, k1.PocoK_Id);
                AreEqual("K1166", k1.Name);
                AreEqual(847, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwelveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes, new { Id = 78 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A121", a1.Name);
                AreEqual(13, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B122", b1.Name);
                AreEqual(28, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C124", c1.Name);
                AreEqual(48, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D127", d1.Name);
                AreEqual(76, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1211", e1.Name);
                AreEqual(115, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1216", f1.Name);
                AreEqual(168, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1222", g1.Name);
                AreEqual(238, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1229", h1.Name);
                AreEqual(328, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1237", i1.Name);
                AreEqual(441, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1246", j1.Name);
                AreEqual(522, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1256", k1.Name);
                AreEqual(748, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(1, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(78, l1.PocoL_Id);
                AreEqual("L1278", l1.Name);
                AreEqual(1080, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThirteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes, new { Id = 91 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A131", a1.Name);
                AreEqual(14, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B132", b1.Name);
                AreEqual(30, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C134", c1.Name);
                AreEqual(51, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D137", d1.Name);
                AreEqual(80, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1311", e1.Name);
                AreEqual(120, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1316", f1.Name);
                AreEqual(174, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1322", g1.Name);
                AreEqual(245, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1329", h1.Name);
                AreEqual(336, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1337", i1.Name); // yes. yes, i am. (boom!)
                AreEqual(450, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1346", j1.Name);
                AreEqual(531, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1356", k1.Name);
                AreEqual(759, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1367", l1.Name);
                AreEqual(960, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(1, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(91, m1.PocoM_Id);
                AreEqual("M1391", m1.Name);
                AreEqual(1352, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes, new { Id = 105 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A141", a1.Name);
                AreEqual(15, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B142", b1.Name);
                AreEqual(32, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C144", c1.Name);
                AreEqual(54, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D147", d1.Name);
                AreEqual(84, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1411", e1.Name);
                AreEqual(125, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1416", f1.Name);
                AreEqual(180, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1422", g1.Name);
                AreEqual(252, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1429", h1.Name);
                AreEqual(344, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1437", i1.Name);
                AreEqual(459, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1446", j1.Name);
                AreEqual(540, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1456", k1.Name);
                AreEqual(770, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1467", l1.Name);
                AreEqual(972, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1479", m1.Name);
                AreEqual(1209, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                IsNotNull(collectionN);
                IsTrue(collectionN.Any());
                AreEqual(1, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                IsNotNull(n1);
                AreEqual(105, n1.PocoN_Id);
                AreEqual("N14105", n1.Name);
                AreEqual(1666, n1.Value);
                AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFifteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes, new { Id = 120 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A151", a1.Name);
                AreEqual(16, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B152", b1.Name);
                AreEqual(34, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C154", c1.Name);
                AreEqual(57, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D157", d1.Name);
                AreEqual(88, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1511", e1.Name);
                AreEqual(130, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1516", f1.Name);
                AreEqual(186, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1522", g1.Name);
                AreEqual(259, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1529", h1.Name);
                AreEqual(352, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1537", i1.Name);
                AreEqual(468, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1546", j1.Name);
                AreEqual(549, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1556", k1.Name);
                AreEqual(781, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1567", l1.Name);
                AreEqual(984, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1579", m1.Name);
                AreEqual(1222, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                IsNotNull(collectionN);
                IsTrue(collectionN.Any());
                AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                IsNotNull(n1);
                AreEqual(92, n1.PocoN_Id);
                AreEqual("N1592", n1.Name);
                AreEqual(1498, n1.Value);
                AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                IsNotNull(collectionO);
                IsTrue(collectionO.Any());
                AreEqual(1, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                IsNotNull(o1);
                AreEqual(120, o1.PocoO_Id);
                AreEqual("O15120", o1.Name);
                AreEqual(2025, o1.Value);
                AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes, new { Id = 136 });

                var record = result.First();
                IsNotNull(record);

                // collectionA
                IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                IsNotNull(collectionA);
                IsTrue(collectionA.Any());
                AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                IsNotNull(a1);
                AreEqual(1, a1.PocoA_Id);
                AreEqual("A161", a1.Name);
                AreEqual(17, a1.Value);
                AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                IsNotNull(collectionB);
                IsTrue(collectionB.Any());
                AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                IsNotNull(b1);
                AreEqual(2, b1.PocoB_Id);
                AreEqual("B162", b1.Name);
                AreEqual(36, b1.Value);
                AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                IsNotNull(collectionC);
                IsTrue(collectionC.Any());
                AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                IsNotNull(b1);
                AreEqual(4, c1.PocoC_Id);
                AreEqual("C164", c1.Name);
                AreEqual(60, c1.Value);
                AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                IsNotNull(collectionD);
                IsTrue(collectionD.Any());
                AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                IsNotNull(d1);
                AreEqual(7, d1.PocoD_Id);
                AreEqual("D167", d1.Name);
                AreEqual(92, d1.Value);
                AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                IsNotNull(collectionE);
                IsTrue(collectionE.Any());
                AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                IsNotNull(e1);
                AreEqual(11, e1.PocoE_Id);
                AreEqual("E1611", e1.Name);
                AreEqual(135, e1.Value);
                AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                IsNotNull(collectionF);
                IsTrue(collectionF.Any());
                AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                IsNotNull(f1);
                AreEqual(16, f1.PocoF_Id);
                AreEqual("F1616", f1.Name);
                AreEqual(192, f1.Value);
                AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                IsNotNull(collectionG);
                IsTrue(collectionG.Any());
                AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                IsNotNull(g1);
                AreEqual(22, g1.PocoG_Id);
                AreEqual("G1622", g1.Name);
                AreEqual(266, g1.Value);
                AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                IsNotNull(collectionH);
                IsTrue(collectionH.Any());
                AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                IsNotNull(h1);
                AreEqual(29, h1.PocoH_Id);
                AreEqual("H1629", h1.Name);
                AreEqual(360, h1.Value);
                AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                IsNotNull(collectionI);
                IsTrue(collectionI.Any());
                AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                IsNotNull(i1);
                AreEqual(37, i1.PocoI_Id);
                AreEqual("I1637", i1.Name);
                AreEqual(477, i1.Value);
                AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                IsNotNull(collectionJ);
                IsTrue(collectionJ.Any());
                AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                IsNotNull(j1);
                AreEqual(46, j1.PocoJ_Id);
                AreEqual("J1646", j1.Name);
                AreEqual(558, j1.Value);
                AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                IsNotNull(collectionK);
                IsTrue(collectionK.Any());
                AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                IsNotNull(k1);
                AreEqual(56, k1.PocoK_Id);
                AreEqual("K1656", k1.Name);
                AreEqual(792, k1.Value);
                AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                IsNotNull(collectionL);
                IsTrue(collectionL.Any());
                AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                IsNotNull(l1);
                AreEqual(67, l1.PocoL_Id);
                AreEqual("L1667", l1.Name);
                AreEqual(996, l1.Value);
                AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                IsNotNull(collectionM);
                IsTrue(collectionM.Any());
                AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                IsNotNull(m1);
                AreEqual(79, m1.PocoM_Id);
                AreEqual("M1679", m1.Name);
                AreEqual(1235, m1.Value);
                AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                IsNotNull(collectionN);
                IsTrue(collectionN.Any());
                AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                IsNotNull(n1);
                AreEqual(92, n1.PocoN_Id);
                AreEqual("N1692", n1.Name);
                AreEqual(1512, n1.Value);
                AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                IsNotNull(collectionO);
                IsTrue(collectionO.Any());
                AreEqual(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                IsNotNull(o1);
                AreEqual(106, o1.PocoO_Id);
                AreEqual("O16106", o1.Name);
                AreEqual(1830, o1.Value);
                AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);

                // collectionP
                IsNotNull(record.CollectionP);
                var collectionP = record.CollectionP;
                IsNotNull(collectionP);
                IsTrue(collectionP.Any());
                AreEqual(1, collectionP.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var p1 = collectionP.First();
                IsNotNull(p1);
                AreEqual(136, p1.PocoP_Id);
                AreEqual("P16136", p1.Name);
                AreEqual(2584, p1.Value);
                AreEqual(DateTime.UtcNow.AddDays(15).Date, p1.Modified.Date);
            }
        }
    }
}
