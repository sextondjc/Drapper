// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Drapper.Tests.Common.CommanderHelper;

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
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A11", a1.Name);
                Assert.AreEqual(1, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwoTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwoTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A21", a1.Name);
                Assert.AreEqual(3, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B22", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(8, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThreeTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A31", a1.Name);
                Assert.AreEqual(4, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B32", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(10, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C34", c1.Name);
                Assert.AreEqual(21, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A41", a1.Name);
                Assert.AreEqual(5, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B42", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(12, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C44", c1.Name);
                Assert.AreEqual(24, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D47", d1.Name);
                Assert.AreEqual(44, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFiveTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A51", a1.Name);
                Assert.AreEqual(6, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B52", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(14, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C54", c1.Name);
                Assert.AreEqual(27, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D57", d1.Name);
                Assert.AreEqual(48, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E511", e1.Name);
                Assert.AreEqual(80, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A61", a1.Name);
                Assert.AreEqual(7, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B62", b1.Name);
                Assert.AreEqual(16, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C64", c1.Name);
                Assert.AreEqual(30, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D67", d1.Name);
                Assert.AreEqual(52, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E611", e1.Name);
                Assert.AreEqual(85, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F616", f1.Name);
                Assert.AreEqual(132, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSevenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A71", a1.Name);
                Assert.AreEqual(8, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B72", b1.Name);
                Assert.AreEqual(18, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C74", c1.Name);
                Assert.AreEqual(33, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D77", d1.Name);
                Assert.AreEqual(56, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E711", e1.Name);
                Assert.AreEqual(90, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F716", f1.Name);
                Assert.AreEqual(138, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G722", g1.Name);
                Assert.AreEqual(203, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithEightTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithEightTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A81", a1.Name);
                Assert.AreEqual(9, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B82", b1.Name);
                Assert.AreEqual(20, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C84", c1.Name);
                Assert.AreEqual(36, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D87", d1.Name);
                Assert.AreEqual(60, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E811", e1.Name);
                Assert.AreEqual(95, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F816", f1.Name);
                Assert.AreEqual(144, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G822", g1.Name);
                Assert.AreEqual(210, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H829", h1.Name);
                Assert.AreEqual(296, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithNineTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithNineTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A91", a1.Name);
                Assert.AreEqual(10, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B92", b1.Name);
                Assert.AreEqual(22, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C94", c1.Name);
                Assert.AreEqual(39, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D97", d1.Name);
                Assert.AreEqual(64, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E911", e1.Name);
                Assert.AreEqual(100, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F916", f1.Name);
                Assert.AreEqual(150, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G922", g1.Name);
                Assert.AreEqual(217, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H929", h1.Name);
                Assert.AreEqual(304, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I937", i1.Name);
                Assert.AreEqual(414, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A101", a1.Name);
                Assert.AreEqual(11, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B102", b1.Name);
                Assert.AreEqual(24, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C104", c1.Name);
                Assert.AreEqual(42, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D107", d1.Name);
                Assert.AreEqual(68, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1011", e1.Name);
                Assert.AreEqual(105, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1016", f1.Name);
                Assert.AreEqual(156, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1022", g1.Name);
                Assert.AreEqual(224, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1029", h1.Name);
                Assert.AreEqual(312, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1037", i1.Name);
                Assert.AreEqual(423, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1046", j1.Name);
                Assert.AreEqual(504, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithElevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithElevenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A111", a1.Name);
                Assert.AreEqual(12, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B112", b1.Name);
                Assert.AreEqual(26, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C114", c1.Name);
                Assert.AreEqual(45, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D117", d1.Name);
                Assert.AreEqual(72, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1111", e1.Name);
                Assert.AreEqual(110, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1116", f1.Name);
                Assert.AreEqual(162, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1122", g1.Name);
                Assert.AreEqual(231, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1129", h1.Name);
                Assert.AreEqual(320, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1137", i1.Name);
                Assert.AreEqual(432, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1146", j1.Name);
                Assert.AreEqual(513, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1156", k1.Name);
                Assert.AreEqual(737, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwelveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A121", a1.Name);
                Assert.AreEqual(13, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B122", b1.Name);
                Assert.AreEqual(28, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C124", c1.Name);
                Assert.AreEqual(48, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D127", d1.Name);
                Assert.AreEqual(76, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1211", e1.Name);
                Assert.AreEqual(115, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1216", f1.Name);
                Assert.AreEqual(168, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1222", g1.Name);
                Assert.AreEqual(238, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1229", h1.Name);
                Assert.AreEqual(328, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1237", i1.Name);
                Assert.AreEqual(441, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1246", j1.Name);
                Assert.AreEqual(522, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1256", k1.Name);
                Assert.AreEqual(748, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1267", l1.Name);
                Assert.AreEqual(948, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThirteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A131", a1.Name);
                Assert.AreEqual(14, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B132", b1.Name);
                Assert.AreEqual(30, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C134", c1.Name);
                Assert.AreEqual(51, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D137", d1.Name);
                Assert.AreEqual(80, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1311", e1.Name);
                Assert.AreEqual(120, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1316", f1.Name);
                Assert.AreEqual(174, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1322", g1.Name);
                Assert.AreEqual(245, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1329", h1.Name);
                Assert.AreEqual(336, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1337", i1.Name); // yes. yes, i am. (boom!)
                Assert.AreEqual(450, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1346", j1.Name);
                Assert.AreEqual(531, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1356", k1.Name);
                Assert.AreEqual(759, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1367", l1.Name);
                Assert.AreEqual(960, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1379", m1.Name);
                Assert.AreEqual(1196, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A141", a1.Name);
                Assert.AreEqual(15, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B142", b1.Name);
                Assert.AreEqual(32, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C144", c1.Name);
                Assert.AreEqual(54, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D147", d1.Name);
                Assert.AreEqual(84, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1411", e1.Name);
                Assert.AreEqual(125, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1416", f1.Name);
                Assert.AreEqual(180, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1422", g1.Name);
                Assert.AreEqual(252, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1429", h1.Name);
                Assert.AreEqual(344, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1437", i1.Name);
                Assert.AreEqual(459, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1446", j1.Name);
                Assert.AreEqual(540, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1456", k1.Name);
                Assert.AreEqual(770, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1467", l1.Name);
                Assert.AreEqual(972, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1479", m1.Name);
                Assert.AreEqual(1209, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                Assert.IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                Assert.IsNotNull(collectionN);
                Assert.IsTrue(collectionN.Any());
                Assert.AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                Assert.IsNotNull(n1);
                Assert.AreEqual(92, n1.PocoN_Id);
                Assert.AreEqual("N1492", n1.Name);
                Assert.AreEqual(1484, n1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFifteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A151", a1.Name);
                Assert.AreEqual(16, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B152", b1.Name);
                Assert.AreEqual(34, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C154", c1.Name);
                Assert.AreEqual(57, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D157", d1.Name);
                Assert.AreEqual(88, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1511", e1.Name);
                Assert.AreEqual(130, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1516", f1.Name);
                Assert.AreEqual(186, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1522", g1.Name);
                Assert.AreEqual(259, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1529", h1.Name);
                Assert.AreEqual(352, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1537", i1.Name);
                Assert.AreEqual(468, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1546", j1.Name);
                Assert.AreEqual(549, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1556", k1.Name);
                Assert.AreEqual(781, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1567", l1.Name);
                Assert.AreEqual(984, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1579", m1.Name);
                Assert.AreEqual(1222, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                Assert.IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                Assert.IsNotNull(collectionN);
                Assert.IsTrue(collectionN.Any());
                Assert.AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                Assert.IsNotNull(n1);
                Assert.AreEqual(92, n1.PocoN_Id);
                Assert.AreEqual("N1592", n1.Name);
                Assert.AreEqual(1498, n1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                Assert.IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                Assert.IsNotNull(collectionO);
                Assert.IsTrue(collectionO.Any());
                Assert.AreEqual(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                Assert.IsNotNull(o1);
                Assert.AreEqual(106, o1.PocoO_Id);
                Assert.AreEqual("O15106", o1.Name);
                Assert.AreEqual(1815, o1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes);

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A161", a1.Name);
                Assert.AreEqual(17, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B162", b1.Name);
                Assert.AreEqual(36, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C164", c1.Name);
                Assert.AreEqual(60, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D167", d1.Name);
                Assert.AreEqual(92, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1611", e1.Name);
                Assert.AreEqual(135, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1616", f1.Name);
                Assert.AreEqual(192, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1622", g1.Name);
                Assert.AreEqual(266, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1629", h1.Name);
                Assert.AreEqual(360, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1637", i1.Name);
                Assert.AreEqual(477, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1646", j1.Name);
                Assert.AreEqual(558, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1656", k1.Name);
                Assert.AreEqual(792, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1667", l1.Name);
                Assert.AreEqual(996, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1679", m1.Name);
                Assert.AreEqual(1235, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                Assert.IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                Assert.IsNotNull(collectionN);
                Assert.IsTrue(collectionN.Any());
                Assert.AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                Assert.IsNotNull(n1);
                Assert.AreEqual(92, n1.PocoN_Id);
                Assert.AreEqual("N1692", n1.Name);
                Assert.AreEqual(1512, n1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                Assert.IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                Assert.IsNotNull(collectionO);
                Assert.IsTrue(collectionO.Any());
                Assert.AreEqual(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                Assert.IsNotNull(o1);
                Assert.AreEqual(106, o1.PocoO_Id);
                Assert.AreEqual("O16106", o1.Name);
                Assert.AreEqual(1830, o1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);

                // collectionP
                Assert.IsNotNull(record.CollectionP);
                var collectionP = record.CollectionP;
                Assert.IsNotNull(collectionP);
                Assert.IsTrue(collectionP.Any());
                Assert.AreEqual(16, collectionP.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var p1 = collectionP.First();
                Assert.IsNotNull(p1);
                Assert.AreEqual(121, p1.PocoP_Id);
                Assert.AreEqual("P16121", p1.Name);
                Assert.AreEqual(2329, p1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(15).Date, p1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithOneTypeAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithOneType, new { Id = 1 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A11", a1.Name);
                Assert.AreEqual(1, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwoTypes, new { Id = 3 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A21", a1.Name);
                Assert.AreEqual(3, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(1, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(3, b1.PocoB_Id);
                Assert.AreEqual("B23", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(10, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThreeTypes, new { Id = 6 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A31", a1.Name);
                Assert.AreEqual(4, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B32", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(10, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(1, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(6, c1.PocoC_Id);
                Assert.AreEqual("C36", c1.Name);
                Assert.AreEqual(27, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourTypes, new { Id = 10 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A41", a1.Name);
                Assert.AreEqual(5, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B42", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(12, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C44", c1.Name);
                Assert.AreEqual(24, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(1, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(10, d1.PocoD_Id);
                Assert.AreEqual("D410", d1.Name);
                Assert.AreEqual(56, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFiveTypes, new { Id = 15 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A51", a1.Name);
                Assert.AreEqual(6, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B52", b1.Name); // rock lobstaaa! 
                Assert.AreEqual(14, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C54", c1.Name);
                Assert.AreEqual(27, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D57", d1.Name);
                Assert.AreEqual(48, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(1, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(15, e1.PocoE_Id);
                Assert.AreEqual("E515", e1.Name);
                Assert.AreEqual(100, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixTypes, new { Id = 21 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A61", a1.Name);
                Assert.AreEqual(7, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B62", b1.Name);
                Assert.AreEqual(16, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C64", c1.Name);
                Assert.AreEqual(30, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D67", d1.Name);
                Assert.AreEqual(52, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E611", e1.Name);
                Assert.AreEqual(85, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(1, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(21, f1.PocoF_Id);
                Assert.AreEqual("F621", f1.Name);
                Assert.AreEqual(162, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSevenTypes, new { Id = 28 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A71", a1.Name);
                Assert.AreEqual(8, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B72", b1.Name);
                Assert.AreEqual(18, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C74", c1.Name);
                Assert.AreEqual(33, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D77", d1.Name);
                Assert.AreEqual(56, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E711", e1.Name);
                Assert.AreEqual(90, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F716", f1.Name);
                Assert.AreEqual(138, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(1, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(28, g1.PocoG_Id);
                Assert.AreEqual("G728", g1.Name);
                Assert.AreEqual(245, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithEightTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithEightTypes, new { Id = 36 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A81", a1.Name);
                Assert.AreEqual(9, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B82", b1.Name);
                Assert.AreEqual(20, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C84", c1.Name);
                Assert.AreEqual(36, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D87", d1.Name);
                Assert.AreEqual(60, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E811", e1.Name);
                Assert.AreEqual(95, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F816", f1.Name);
                Assert.AreEqual(144, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G822", g1.Name);
                Assert.AreEqual(210, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(1, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(36, h1.PocoH_Id);
                Assert.AreEqual("H836", h1.Name);
                Assert.AreEqual(352, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithNineTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithNineTypes, new { Id = 45 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A91", a1.Name);
                Assert.AreEqual(10, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B92", b1.Name);
                Assert.AreEqual(22, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C94", c1.Name);
                Assert.AreEqual(39, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D97", d1.Name);
                Assert.AreEqual(64, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E911", e1.Name);
                Assert.AreEqual(100, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F916", f1.Name);
                Assert.AreEqual(150, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G922", g1.Name);
                Assert.AreEqual(217, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H929", h1.Name);
                Assert.AreEqual(304, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(1, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(45, i1.PocoI_Id);
                Assert.AreEqual("I945", i1.Name);
                Assert.AreEqual(486, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTenTypes, new { Id = 55 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A101", a1.Name);
                Assert.AreEqual(11, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B102", b1.Name);
                Assert.AreEqual(24, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C104", c1.Name);
                Assert.AreEqual(42, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D107", d1.Name);
                Assert.AreEqual(68, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1011", e1.Name);
                Assert.AreEqual(105, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1016", f1.Name);
                Assert.AreEqual(156, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1022", g1.Name);
                Assert.AreEqual(224, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1029", h1.Name);
                Assert.AreEqual(312, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1037", i1.Name);
                Assert.AreEqual(423, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(1, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(55, j1.PocoJ_Id);
                Assert.AreEqual("J1055", j1.Name);
                Assert.AreEqual(585, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithElevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithElevenTypes, new { Id = 66 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A111", a1.Name);
                Assert.AreEqual(12, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B112", b1.Name);
                Assert.AreEqual(26, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C114", c1.Name);
                Assert.AreEqual(45, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D117", d1.Name);
                Assert.AreEqual(72, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1111", e1.Name);
                Assert.AreEqual(110, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1116", f1.Name);
                Assert.AreEqual(162, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1122", g1.Name);
                Assert.AreEqual(231, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1129", h1.Name);
                Assert.AreEqual(320, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1137", i1.Name);
                Assert.AreEqual(432, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1146", j1.Name);
                Assert.AreEqual(513, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(1, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(66, k1.PocoK_Id);
                Assert.AreEqual("K1166", k1.Name);
                Assert.AreEqual(847, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithTwelveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes, new { Id = 78 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A121", a1.Name);
                Assert.AreEqual(13, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B122", b1.Name);
                Assert.AreEqual(28, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C124", c1.Name);
                Assert.AreEqual(48, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D127", d1.Name);
                Assert.AreEqual(76, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1211", e1.Name);
                Assert.AreEqual(115, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1216", f1.Name);
                Assert.AreEqual(168, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1222", g1.Name);
                Assert.AreEqual(238, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1229", h1.Name);
                Assert.AreEqual(328, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1237", i1.Name);
                Assert.AreEqual(441, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1246", j1.Name);
                Assert.AreEqual(522, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1256", k1.Name);
                Assert.AreEqual(748, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(1, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(78, l1.PocoL_Id);
                Assert.AreEqual("L1278", l1.Name);
                Assert.AreEqual(1080, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithThirteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes, new { Id = 91 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A131", a1.Name);
                Assert.AreEqual(14, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B132", b1.Name);
                Assert.AreEqual(30, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C134", c1.Name);
                Assert.AreEqual(51, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D137", d1.Name);
                Assert.AreEqual(80, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1311", e1.Name);
                Assert.AreEqual(120, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1316", f1.Name);
                Assert.AreEqual(174, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1322", g1.Name);
                Assert.AreEqual(245, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1329", h1.Name);
                Assert.AreEqual(336, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1337", i1.Name); // yes. yes, i am. (boom!)
                Assert.AreEqual(450, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1346", j1.Name);
                Assert.AreEqual(531, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1356", k1.Name);
                Assert.AreEqual(759, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1367", l1.Name);
                Assert.AreEqual(960, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(1, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(91, m1.PocoM_Id);
                Assert.AreEqual("M1391", m1.Name);
                Assert.AreEqual(1352, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFourteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes, new { Id = 105 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A141", a1.Name);
                Assert.AreEqual(15, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B142", b1.Name);
                Assert.AreEqual(32, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C144", c1.Name);
                Assert.AreEqual(54, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D147", d1.Name);
                Assert.AreEqual(84, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1411", e1.Name);
                Assert.AreEqual(125, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1416", f1.Name);
                Assert.AreEqual(180, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1422", g1.Name);
                Assert.AreEqual(252, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1429", h1.Name);
                Assert.AreEqual(344, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1437", i1.Name);
                Assert.AreEqual(459, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1446", j1.Name);
                Assert.AreEqual(540, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1456", k1.Name);
                Assert.AreEqual(770, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1467", l1.Name);
                Assert.AreEqual(972, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1479", m1.Name);
                Assert.AreEqual(1209, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                Assert.IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                Assert.IsNotNull(collectionN);
                Assert.IsTrue(collectionN.Any());
                Assert.AreEqual(1, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                Assert.IsNotNull(n1);
                Assert.AreEqual(105, n1.PocoN_Id);
                Assert.AreEqual("N14105", n1.Name);
                Assert.AreEqual(1666, n1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithFifteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes, new { Id = 120 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A151", a1.Name);
                Assert.AreEqual(16, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B152", b1.Name);
                Assert.AreEqual(34, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C154", c1.Name);
                Assert.AreEqual(57, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D157", d1.Name);
                Assert.AreEqual(88, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1511", e1.Name);
                Assert.AreEqual(130, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1516", f1.Name);
                Assert.AreEqual(186, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1522", g1.Name);
                Assert.AreEqual(259, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1529", h1.Name);
                Assert.AreEqual(352, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1537", i1.Name);
                Assert.AreEqual(468, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1546", j1.Name);
                Assert.AreEqual(549, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1556", k1.Name);
                Assert.AreEqual(781, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1567", l1.Name);
                Assert.AreEqual(984, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1579", m1.Name);
                Assert.AreEqual(1222, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                Assert.IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                Assert.IsNotNull(collectionN);
                Assert.IsTrue(collectionN.Any());
                Assert.AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                Assert.IsNotNull(n1);
                Assert.AreEqual(92, n1.PocoN_Id);
                Assert.AreEqual("N1592", n1.Name);
                Assert.AreEqual(1498, n1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                Assert.IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                Assert.IsNotNull(collectionO);
                Assert.IsTrue(collectionO.Any());
                Assert.AreEqual(1, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                Assert.IsNotNull(o1);
                Assert.AreEqual(120, o1.PocoO_Id);
                Assert.AreEqual("O15120", o1.Name);
                Assert.AreEqual(2025, o1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);
            }
        }

        [TestMethod]
        public async Task WithSixteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes, new { Id = 136 });

                var record = result.First();
                Assert.IsNotNull(record);

                // collectionA
                Assert.IsNotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                Assert.IsNotNull(collectionA);
                Assert.IsTrue(collectionA.Any());
                Assert.AreEqual(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                Assert.IsNotNull(a1);
                Assert.AreEqual(1, a1.PocoA_Id);
                Assert.AreEqual("A161", a1.Name);
                Assert.AreEqual(17, a1.Value);
                Assert.AreEqual(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                Assert.IsNotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                Assert.IsNotNull(collectionB);
                Assert.IsTrue(collectionB.Any());
                Assert.AreEqual(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(2, b1.PocoB_Id);
                Assert.AreEqual("B162", b1.Name);
                Assert.AreEqual(36, b1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                Assert.IsNotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                Assert.IsNotNull(collectionC);
                Assert.IsTrue(collectionC.Any());
                Assert.AreEqual(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                Assert.IsNotNull(b1);
                Assert.AreEqual(4, c1.PocoC_Id);
                Assert.AreEqual("C164", c1.Name);
                Assert.AreEqual(60, c1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                Assert.IsNotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                Assert.IsNotNull(collectionD);
                Assert.IsTrue(collectionD.Any());
                Assert.AreEqual(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                Assert.IsNotNull(d1);
                Assert.AreEqual(7, d1.PocoD_Id);
                Assert.AreEqual("D167", d1.Name);
                Assert.AreEqual(92, d1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                Assert.IsNotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                Assert.IsNotNull(collectionE);
                Assert.IsTrue(collectionE.Any());
                Assert.AreEqual(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                Assert.IsNotNull(e1);
                Assert.AreEqual(11, e1.PocoE_Id);
                Assert.AreEqual("E1611", e1.Name);
                Assert.AreEqual(135, e1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                Assert.IsNotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                Assert.IsNotNull(collectionF);
                Assert.IsTrue(collectionF.Any());
                Assert.AreEqual(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                Assert.IsNotNull(f1);
                Assert.AreEqual(16, f1.PocoF_Id);
                Assert.AreEqual("F1616", f1.Name);
                Assert.AreEqual(192, f1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                Assert.IsNotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                Assert.IsNotNull(collectionG);
                Assert.IsTrue(collectionG.Any());
                Assert.AreEqual(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                Assert.IsNotNull(g1);
                Assert.AreEqual(22, g1.PocoG_Id);
                Assert.AreEqual("G1622", g1.Name);
                Assert.AreEqual(266, g1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                Assert.IsNotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                Assert.IsNotNull(collectionH);
                Assert.IsTrue(collectionH.Any());
                Assert.AreEqual(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                Assert.IsNotNull(h1);
                Assert.AreEqual(29, h1.PocoH_Id);
                Assert.AreEqual("H1629", h1.Name);
                Assert.AreEqual(360, h1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                Assert.IsNotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                Assert.IsNotNull(collectionI);
                Assert.IsTrue(collectionI.Any());
                Assert.AreEqual(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                Assert.IsNotNull(i1);
                Assert.AreEqual(37, i1.PocoI_Id);
                Assert.AreEqual("I1637", i1.Name);
                Assert.AreEqual(477, i1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                Assert.IsNotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                Assert.IsNotNull(collectionJ);
                Assert.IsTrue(collectionJ.Any());
                Assert.AreEqual(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                Assert.IsNotNull(j1);
                Assert.AreEqual(46, j1.PocoJ_Id);
                Assert.AreEqual("J1646", j1.Name);
                Assert.AreEqual(558, j1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                Assert.IsNotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                Assert.IsNotNull(collectionK);
                Assert.IsTrue(collectionK.Any());
                Assert.AreEqual(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                Assert.IsNotNull(k1);
                Assert.AreEqual(56, k1.PocoK_Id);
                Assert.AreEqual("K1656", k1.Name);
                Assert.AreEqual(792, k1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                Assert.IsNotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                Assert.IsNotNull(collectionL);
                Assert.IsTrue(collectionL.Any());
                Assert.AreEqual(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                Assert.IsNotNull(l1);
                Assert.AreEqual(67, l1.PocoL_Id);
                Assert.AreEqual("L1667", l1.Name);
                Assert.AreEqual(996, l1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                Assert.IsNotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                Assert.IsNotNull(collectionM);
                Assert.IsTrue(collectionM.Any());
                Assert.AreEqual(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                Assert.IsNotNull(m1);
                Assert.AreEqual(79, m1.PocoM_Id);
                Assert.AreEqual("M1679", m1.Name);
                Assert.AreEqual(1235, m1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                Assert.IsNotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                Assert.IsNotNull(collectionN);
                Assert.IsTrue(collectionN.Any());
                Assert.AreEqual(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                Assert.IsNotNull(n1);
                Assert.AreEqual(92, n1.PocoN_Id);
                Assert.AreEqual("N1692", n1.Name);
                Assert.AreEqual(1512, n1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                Assert.IsNotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                Assert.IsNotNull(collectionO);
                Assert.IsTrue(collectionO.Any());
                Assert.AreEqual(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                Assert.IsNotNull(o1);
                Assert.AreEqual(106, o1.PocoO_Id);
                Assert.AreEqual("O16106", o1.Name);
                Assert.AreEqual(1830, o1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);

                // collectionP
                Assert.IsNotNull(record.CollectionP);
                var collectionP = record.CollectionP;
                Assert.IsNotNull(collectionP);
                Assert.IsTrue(collectionP.Any());
                Assert.AreEqual(1, collectionP.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var p1 = collectionP.First();
                Assert.IsNotNull(p1);
                Assert.AreEqual(136, p1.PocoP_Id);
                Assert.AreEqual("P16136", p1.Name);
                Assert.AreEqual(2584, p1.Value);
                Assert.AreEqual(DateTime.UtcNow.AddDays(15).Date, p1.Modified.Date);
            }
        }
    }
}
