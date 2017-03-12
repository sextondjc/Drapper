// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Linq;
using System.Threading.Tasks;
using static Drapper.Tests.Helpers.CommanderHelper;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    [Collection("Integration")]
    public class MultipleAsync
    {
        [Fact]
        public async Task WithOneType()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithOneType);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A11", a1.Name);
                Equal(1, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTwoTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwoTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A21", a1.Name);
                Equal(3, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B22", b1.Name); // rock lobstaaa! 
                Equal(8, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithThreeTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThreeTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A31", a1.Name);
                Equal(4, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B32", b1.Name); // rock lobstaaa! 
                Equal(10, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C34", c1.Name);
                Equal(21, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFourTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A41", a1.Name);
                Equal(5, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B42", b1.Name); // rock lobstaaa! 
                Equal(12, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C44", c1.Name);
                Equal(24, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D47", d1.Name);
                Equal(44, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFiveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFiveTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A51", a1.Name);
                Equal(6, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B52", b1.Name); // rock lobstaaa! 
                Equal(14, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C54", c1.Name);
                Equal(27, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D57", d1.Name);
                Equal(48, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E511", e1.Name);
                Equal(80, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSixTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A61", a1.Name);
                Equal(7, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B62", b1.Name);
                Equal(16, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C64", c1.Name);
                Equal(30, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D67", d1.Name);
                Equal(52, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E611", e1.Name);
                Equal(85, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F616", f1.Name);
                Equal(132, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSevenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A71", a1.Name);
                Equal(8, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B72", b1.Name);
                Equal(18, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C74", c1.Name);
                Equal(33, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D77", d1.Name);
                Equal(56, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E711", e1.Name);
                Equal(90, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F716", f1.Name);
                Equal(138, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G722", g1.Name);
                Equal(203, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithEightTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithEightTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A81", a1.Name);
                Equal(9, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B82", b1.Name);
                Equal(20, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C84", c1.Name);
                Equal(36, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D87", d1.Name);
                Equal(60, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E811", e1.Name);
                Equal(95, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F816", f1.Name);
                Equal(144, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G822", g1.Name);
                Equal(210, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H829", h1.Name);
                Equal(296, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithNineTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithNineTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A91", a1.Name);
                Equal(10, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B92", b1.Name);
                Equal(22, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C94", c1.Name);
                Equal(39, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D97", d1.Name);
                Equal(64, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E911", e1.Name);
                Equal(100, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F916", f1.Name);
                Equal(150, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G922", g1.Name);
                Equal(217, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H929", h1.Name);
                Equal(304, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I937", i1.Name);
                Equal(414, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A101", a1.Name);
                Equal(11, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B102", b1.Name);
                Equal(24, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C104", c1.Name);
                Equal(42, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D107", d1.Name);
                Equal(68, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1011", e1.Name);
                Equal(105, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1016", f1.Name);
                Equal(156, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1022", g1.Name);
                Equal(224, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1029", h1.Name);
                Equal(312, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1037", i1.Name);
                Equal(423, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1046", j1.Name);
                Equal(504, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithElevenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithElevenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A111", a1.Name);
                Equal(12, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B112", b1.Name);
                Equal(26, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C114", c1.Name);
                Equal(45, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D117", d1.Name);
                Equal(72, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1111", e1.Name);
                Equal(110, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1116", f1.Name);
                Equal(162, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1122", g1.Name);
                Equal(231, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1129", h1.Name);
                Equal(320, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1137", i1.Name);
                Equal(432, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1146", j1.Name);
                Equal(513, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1156", k1.Name);
                Equal(737, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTwelveTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A121", a1.Name);
                Equal(13, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B122", b1.Name);
                Equal(28, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C124", c1.Name);
                Equal(48, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D127", d1.Name);
                Equal(76, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1211", e1.Name);
                Equal(115, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1216", f1.Name);
                Equal(168, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1222", g1.Name);
                Equal(238, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1229", h1.Name);
                Equal(328, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1237", i1.Name);
                Equal(441, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1246", j1.Name);
                Equal(522, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1256", k1.Name);
                Equal(748, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1267", l1.Name);
                Equal(948, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithThirteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A131", a1.Name);
                Equal(14, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B132", b1.Name);
                Equal(30, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C134", c1.Name);
                Equal(51, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D137", d1.Name);
                Equal(80, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1311", e1.Name);
                Equal(120, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1316", f1.Name);
                Equal(174, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1322", g1.Name);
                Equal(245, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1329", h1.Name);
                Equal(336, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1337", i1.Name); // yes. yes, i am. (boom!)
                Equal(450, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1346", j1.Name);
                Equal(531, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1356", k1.Name);
                Equal(759, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1367", l1.Name);
                Equal(960, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1379", m1.Name);
                Equal(1196, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFourteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A141", a1.Name);
                Equal(15, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B142", b1.Name);
                Equal(32, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C144", c1.Name);
                Equal(54, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D147", d1.Name);
                Equal(84, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1411", e1.Name);
                Equal(125, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1416", f1.Name);
                Equal(180, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1422", g1.Name);
                Equal(252, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1429", h1.Name);
                Equal(344, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1437", i1.Name);
                Equal(459, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1446", j1.Name);
                Equal(540, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1456", k1.Name);
                Equal(770, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1467", l1.Name);
                Equal(972, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1479", m1.Name);
                Equal(1209, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                NotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                NotNull(collectionN);
                True(collectionN.Any());
                Equal(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                NotNull(n1);
                Equal(92, n1.PocoN_Id);
                Equal("N1492", n1.Name);
                Equal(1484, n1.Value);
                Equal(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFifteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A151", a1.Name);
                Equal(16, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B152", b1.Name);
                Equal(34, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C154", c1.Name);
                Equal(57, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D157", d1.Name);
                Equal(88, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1511", e1.Name);
                Equal(130, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1516", f1.Name);
                Equal(186, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1522", g1.Name);
                Equal(259, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1529", h1.Name);
                Equal(352, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1537", i1.Name);
                Equal(468, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1546", j1.Name);
                Equal(549, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1556", k1.Name);
                Equal(781, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1567", l1.Name);
                Equal(984, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1579", m1.Name);
                Equal(1222, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                NotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                NotNull(collectionN);
                True(collectionN.Any());
                Equal(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                NotNull(n1);
                Equal(92, n1.PocoN_Id);
                Equal("N1592", n1.Name);
                Equal(1498, n1.Value);
                Equal(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                NotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                NotNull(collectionO);
                True(collectionO.Any());
                Equal(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                NotNull(o1);
                Equal(106, o1.PocoO_Id);
                Equal("O15106", o1.Name);
                Equal(1815, o1.Value);
                Equal(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSixteenTypes()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes);

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A161", a1.Name);
                Equal(17, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B162", b1.Name);
                Equal(36, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C164", c1.Name);
                Equal(60, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D167", d1.Name);
                Equal(92, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1611", e1.Name);
                Equal(135, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1616", f1.Name);
                Equal(192, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1622", g1.Name);
                Equal(266, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1629", h1.Name);
                Equal(360, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1637", i1.Name);
                Equal(477, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1646", j1.Name);
                Equal(558, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1656", k1.Name);
                Equal(792, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1667", l1.Name);
                Equal(996, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1679", m1.Name);
                Equal(1235, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                NotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                NotNull(collectionN);
                True(collectionN.Any());
                Equal(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                NotNull(n1);
                Equal(92, n1.PocoN_Id);
                Equal("N1692", n1.Name);
                Equal(1512, n1.Value);
                Equal(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                NotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                NotNull(collectionO);
                True(collectionO.Any());
                Equal(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                NotNull(o1);
                Equal(106, o1.PocoO_Id);
                Equal("O16106", o1.Name);
                Equal(1830, o1.Value);
                Equal(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);

                // collectionP
                NotNull(record.CollectionP);
                var collectionP = record.CollectionP;
                NotNull(collectionP);
                True(collectionP.Any());
                Equal(16, collectionP.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var p1 = collectionP.First();
                NotNull(p1);
                Equal(121, p1.PocoP_Id);
                Equal("P16121", p1.Name);
                Equal(2329, p1.Value);
                Equal(DateTime.UtcNow.AddDays(15).Date, p1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithOneTypeAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithOneType, new { Id = 1 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A11", a1.Name);
                Equal(1, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTwoTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwoTypes, new { Id = 3 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A21", a1.Name);
                Equal(3, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(1, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(3, b1.PocoB_Id);
                Equal("B23", b1.Name); // rock lobstaaa! 
                Equal(10, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithThreeTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThreeTypes, new { Id = 6 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A31", a1.Name);
                Equal(4, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B32", b1.Name); // rock lobstaaa! 
                Equal(10, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(1, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(6, c1.PocoC_Id);
                Equal("C36", c1.Name);
                Equal(27, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFourTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourTypes, new { Id = 10 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A41", a1.Name);
                Equal(5, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B42", b1.Name); // rock lobstaaa! 
                Equal(12, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C44", c1.Name);
                Equal(24, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(1, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(10, d1.PocoD_Id);
                Equal("D410", d1.Name);
                Equal(56, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFiveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFiveTypes, new { Id = 15 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A51", a1.Name);
                Equal(6, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B52", b1.Name); // rock lobstaaa! 
                Equal(14, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C54", c1.Name);
                Equal(27, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D57", d1.Name);
                Equal(48, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(1, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(15, e1.PocoE_Id);
                Equal("E515", e1.Name);
                Equal(100, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSixTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixTypes, new { Id = 21 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A61", a1.Name);
                Equal(7, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B62", b1.Name);
                Equal(16, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C64", c1.Name);
                Equal(30, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D67", d1.Name);
                Equal(52, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E611", e1.Name);
                Equal(85, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(1, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(21, f1.PocoF_Id);
                Equal("F621", f1.Name);
                Equal(162, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSevenTypes, new { Id = 28 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A71", a1.Name);
                Equal(8, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B72", b1.Name);
                Equal(18, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C74", c1.Name);
                Equal(33, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D77", d1.Name);
                Equal(56, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E711", e1.Name);
                Equal(90, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F716", f1.Name);
                Equal(138, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(1, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(28, g1.PocoG_Id);
                Equal("G728", g1.Name);
                Equal(245, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithEightTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithEightTypes, new { Id = 36 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A81", a1.Name);
                Equal(9, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B82", b1.Name);
                Equal(20, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C84", c1.Name);
                Equal(36, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D87", d1.Name);
                Equal(60, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E811", e1.Name);
                Equal(95, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F816", f1.Name);
                Equal(144, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G822", g1.Name);
                Equal(210, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(1, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(36, h1.PocoH_Id);
                Equal("H836", h1.Name);
                Equal(352, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithNineTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithNineTypes, new { Id = 45 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A91", a1.Name);
                Equal(10, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B92", b1.Name);
                Equal(22, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C94", c1.Name);
                Equal(39, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D97", d1.Name);
                Equal(64, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E911", e1.Name);
                Equal(100, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F916", f1.Name);
                Equal(150, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G922", g1.Name);
                Equal(217, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H929", h1.Name);
                Equal(304, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(1, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(45, i1.PocoI_Id);
                Equal("I945", i1.Name);
                Equal(486, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTenTypes, new { Id = 55 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A101", a1.Name);
                Equal(11, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B102", b1.Name);
                Equal(24, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C104", c1.Name);
                Equal(42, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D107", d1.Name);
                Equal(68, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1011", e1.Name);
                Equal(105, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1016", f1.Name);
                Equal(156, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1022", g1.Name);
                Equal(224, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1029", h1.Name);
                Equal(312, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1037", i1.Name);
                Equal(423, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(1, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(55, j1.PocoJ_Id);
                Equal("J1055", j1.Name);
                Equal(585, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithElevenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithElevenTypes, new { Id = 66 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A111", a1.Name);
                Equal(12, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B112", b1.Name);
                Equal(26, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C114", c1.Name);
                Equal(45, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D117", d1.Name);
                Equal(72, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1111", e1.Name);
                Equal(110, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1116", f1.Name);
                Equal(162, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1122", g1.Name);
                Equal(231, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1129", h1.Name);
                Equal(320, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1137", i1.Name);
                Equal(432, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1146", j1.Name);
                Equal(513, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(1, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(66, k1.PocoK_Id);
                Equal("K1166", k1.Name);
                Equal(847, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithTwelveTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes, new { Id = 78 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A121", a1.Name);
                Equal(13, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B122", b1.Name);
                Equal(28, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C124", c1.Name);
                Equal(48, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D127", d1.Name);
                Equal(76, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1211", e1.Name);
                Equal(115, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1216", f1.Name);
                Equal(168, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1222", g1.Name);
                Equal(238, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1229", h1.Name);
                Equal(328, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1237", i1.Name);
                Equal(441, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1246", j1.Name);
                Equal(522, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1256", k1.Name);
                Equal(748, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(1, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(78, l1.PocoL_Id);
                Equal("L1278", l1.Name);
                Equal(1080, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithThirteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes, new { Id = 91 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A131", a1.Name);
                Equal(14, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B132", b1.Name);
                Equal(30, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C134", c1.Name);
                Equal(51, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D137", d1.Name);
                Equal(80, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1311", e1.Name);
                Equal(120, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1316", f1.Name);
                Equal(174, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1322", g1.Name);
                Equal(245, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1329", h1.Name);
                Equal(336, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1337", i1.Name); // yes. yes, i am. (boom!)
                Equal(450, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1346", j1.Name);
                Equal(531, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1356", k1.Name);
                Equal(759, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1367", l1.Name);
                Equal(960, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(1, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(91, m1.PocoM_Id);
                Equal("M1391", m1.Name);
                Equal(1352, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFourteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes, new { Id = 105 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A141", a1.Name);
                Equal(15, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B142", b1.Name);
                Equal(32, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C144", c1.Name);
                Equal(54, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D147", d1.Name);
                Equal(84, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1411", e1.Name);
                Equal(125, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1416", f1.Name);
                Equal(180, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1422", g1.Name);
                Equal(252, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1429", h1.Name);
                Equal(344, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1437", i1.Name);
                Equal(459, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1446", j1.Name);
                Equal(540, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1456", k1.Name);
                Equal(770, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1467", l1.Name);
                Equal(972, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1479", m1.Name);
                Equal(1209, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                NotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                NotNull(collectionN);
                True(collectionN.Any());
                Equal(1, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                NotNull(n1);
                Equal(105, n1.PocoN_Id);
                Equal("N14105", n1.Name);
                Equal(1666, n1.Value);
                Equal(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithFifteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes, new { Id = 120 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A151", a1.Name);
                Equal(16, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B152", b1.Name);
                Equal(34, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C154", c1.Name);
                Equal(57, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D157", d1.Name);
                Equal(88, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1511", e1.Name);
                Equal(130, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1516", f1.Name);
                Equal(186, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1522", g1.Name);
                Equal(259, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1529", h1.Name);
                Equal(352, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1537", i1.Name);
                Equal(468, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1546", j1.Name);
                Equal(549, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1556", k1.Name);
                Equal(781, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1567", l1.Name);
                Equal(984, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1579", m1.Name);
                Equal(1222, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                NotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                NotNull(collectionN);
                True(collectionN.Any());
                Equal(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                NotNull(n1);
                Equal(92, n1.PocoN_Id);
                Equal("N1592", n1.Name);
                Equal(1498, n1.Value);
                Equal(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                NotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                NotNull(collectionO);
                True(collectionO.Any());
                Equal(1, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                NotNull(o1);
                Equal(120, o1.PocoO_Id);
                Equal("O15120", o1.Name);
                Equal(2025, o1.Value);
                Equal(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);
            }
        }

        [Fact]
        public async Task WithSixteenTypesAndParameters()
        {
            using (var commander = CreateCommander())
            {
                var result = await commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes, new { Id = 136 });

                var record = result.First();
                NotNull(record);

                // collectionA
                NotNull(record.CollectionA);
                var collectionA = record.CollectionA;
                NotNull(collectionA);
                True(collectionA.Any());
                Equal(1, collectionA.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var a1 = collectionA.First();
                NotNull(a1);
                Equal(1, a1.PocoA_Id);
                Equal("A161", a1.Name);
                Equal(17, a1.Value);
                Equal(DateTime.UtcNow.Date, a1.Modified.Date);

                // collectionB
                NotNull(record.CollectionB);
                var collectionB = record.CollectionB;
                NotNull(collectionB);
                True(collectionB.Any());
                Equal(2, collectionB.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var b1 = collectionB.First();
                NotNull(b1);
                Equal(2, b1.PocoB_Id);
                Equal("B162", b1.Name);
                Equal(36, b1.Value);
                Equal(DateTime.UtcNow.AddDays(1).Date, b1.Modified.Date);

                // collectionC
                NotNull(record.CollectionC);
                var collectionC = record.CollectionC;
                NotNull(collectionC);
                True(collectionC.Any());
                Equal(3, collectionC.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var c1 = collectionC.First();
                NotNull(b1);
                Equal(4, c1.PocoC_Id);
                Equal("C164", c1.Name);
                Equal(60, c1.Value);
                Equal(DateTime.UtcNow.AddDays(2).Date, c1.Modified.Date);

                // collectionD
                NotNull(record.CollectionD);
                var collectionD = record.CollectionD;
                NotNull(collectionD);
                True(collectionD.Any());
                Equal(4, collectionD.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var d1 = collectionD.First();
                NotNull(d1);
                Equal(7, d1.PocoD_Id);
                Equal("D167", d1.Name);
                Equal(92, d1.Value);
                Equal(DateTime.UtcNow.AddDays(3).Date, d1.Modified.Date);

                // collectionE
                NotNull(record.CollectionE);
                var collectionE = record.CollectionE;
                NotNull(collectionE);
                True(collectionE.Any());
                Equal(5, collectionE.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var e1 = collectionE.First();
                NotNull(e1);
                Equal(11, e1.PocoE_Id);
                Equal("E1611", e1.Name);
                Equal(135, e1.Value);
                Equal(DateTime.UtcNow.AddDays(4).Date, e1.Modified.Date);

                // collectionF
                NotNull(record.CollectionF);
                var collectionF = record.CollectionF;
                NotNull(collectionF);
                True(collectionF.Any());
                Equal(6, collectionF.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var f1 = collectionF.First();
                NotNull(f1);
                Equal(16, f1.PocoF_Id);
                Equal("F1616", f1.Name);
                Equal(192, f1.Value);
                Equal(DateTime.UtcNow.AddDays(5).Date, f1.Modified.Date);

                // collectionG
                NotNull(record.CollectionG);
                var collectionG = record.CollectionG;
                NotNull(collectionG);
                True(collectionG.Any());
                Equal(7, collectionG.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var g1 = collectionG.First();
                NotNull(g1);
                Equal(22, g1.PocoG_Id);
                Equal("G1622", g1.Name);
                Equal(266, g1.Value);
                Equal(DateTime.UtcNow.AddDays(6).Date, g1.Modified.Date);

                // collectionH
                NotNull(record.CollectionH);
                var collectionH = record.CollectionH;
                NotNull(collectionH);
                True(collectionH.Any());
                Equal(8, collectionH.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var h1 = collectionH.First();
                NotNull(h1);
                Equal(29, h1.PocoH_Id);
                Equal("H1629", h1.Name);
                Equal(360, h1.Value);
                Equal(DateTime.UtcNow.AddDays(7).Date, h1.Modified.Date);

                // collectionI
                NotNull(record.CollectionI);
                var collectionI = record.CollectionI;
                NotNull(collectionI);
                True(collectionI.Any());
                Equal(9, collectionI.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var i1 = collectionI.First();
                NotNull(i1);
                Equal(37, i1.PocoI_Id);
                Equal("I1637", i1.Name);
                Equal(477, i1.Value);
                Equal(DateTime.UtcNow.AddDays(8).Date, i1.Modified.Date);

                // collectionJ
                NotNull(record.CollectionJ);
                var collectionJ = record.CollectionJ;
                NotNull(collectionJ);
                True(collectionJ.Any());
                Equal(10, collectionJ.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var j1 = collectionJ.First();
                NotNull(j1);
                Equal(46, j1.PocoJ_Id);
                Equal("J1646", j1.Name);
                Equal(558, j1.Value);
                Equal(DateTime.UtcNow.AddDays(9).Date, j1.Modified.Date);

                // collectionK
                NotNull(record.CollectionK);
                var collectionK = record.CollectionK;
                NotNull(collectionK);
                True(collectionK.Any());
                Equal(11, collectionK.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var k1 = collectionK.First();
                NotNull(k1);
                Equal(56, k1.PocoK_Id);
                Equal("K1656", k1.Name);
                Equal(792, k1.Value);
                Equal(DateTime.UtcNow.AddDays(10).Date, k1.Modified.Date);

                // collectionL
                NotNull(record.CollectionL);
                var collectionL = record.CollectionL;
                NotNull(collectionL);
                True(collectionL.Any());
                Equal(12, collectionL.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var l1 = collectionL.First();
                NotNull(l1);
                Equal(67, l1.PocoL_Id);
                Equal("L1667", l1.Name);
                Equal(996, l1.Value);
                Equal(DateTime.UtcNow.AddDays(11).Date, l1.Modified.Date);

                // collectionM
                NotNull(record.CollectionM);
                var collectionM = record.CollectionM;
                NotNull(collectionM);
                True(collectionM.Any());
                Equal(13, collectionM.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var m1 = collectionM.First();
                NotNull(m1);
                Equal(79, m1.PocoM_Id);
                Equal("M1679", m1.Name);
                Equal(1235, m1.Value);
                Equal(DateTime.UtcNow.AddDays(12).Date, m1.Modified.Date);

                // collectionN
                NotNull(record.CollectionN);
                var collectionN = record.CollectionN;
                NotNull(collectionN);
                True(collectionN.Any());
                Equal(14, collectionN.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var n1 = collectionN.First();
                NotNull(n1);
                Equal(92, n1.PocoN_Id);
                Equal("N1692", n1.Name);
                Equal(1512, n1.Value);
                Equal(DateTime.UtcNow.AddDays(13).Date, n1.Modified.Date);

                // collectionO
                NotNull(record.CollectionO);
                var collectionO = record.CollectionO;
                NotNull(collectionO);
                True(collectionO.Any());
                Equal(15, collectionO.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var o1 = collectionO.First();
                NotNull(o1);
                Equal(106, o1.PocoO_Id);
                Equal("O16106", o1.Name);
                Equal(1830, o1.Value);
                Equal(DateTime.UtcNow.AddDays(14).Date, o1.Modified.Date);

                // collectionP
                NotNull(record.CollectionP);
                var collectionP = record.CollectionP;
                NotNull(collectionP);
                True(collectionP.Any());
                Equal(1, collectionP.Count());

                // evaluate first result (way too much mission to evaluate all of them). 
                var p1 = collectionP.First();
                NotNull(p1);
                Equal(136, p1.PocoP_Id);
                Equal("P16136", p1.Name);
                Equal(2584, p1.Value);
                Equal(DateTime.UtcNow.AddDays(15).Date, p1.Modified.Date);
            }
        }
    }
}
