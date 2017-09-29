//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:44)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Drapper.Tests.Models;
using Xunit;

namespace Drapper.Databases.Integration.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class QueryAsync
    {
        [Fact]
        public async Task MultipleEightTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithEightTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A81", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B82", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C84", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D87", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E811", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F816", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G822", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H829", h1.Name);
            Assert.Equal(43, h1.Value);
        }

        [Fact]
        public async Task MultipleEightTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithEightTypes, new {Id = 36});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A81", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B82", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C84", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D87", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E811", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F816", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G822", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(1, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(36, h1.PocoH_Id);
            Assert.Equal("H836", h1.Name);
            Assert.Equal(50, h1.Value);
        }

        [Fact]
        public async Task MultipleElevenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithElevenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A111", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B112", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C114", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D117", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1111", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1116", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1122", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1129", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1137", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1146", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1156", k1.Name);
            Assert.Equal(70, k1.Value);
        }

        [Fact]
        public async Task MultipleElevenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithElevenTypes, new {Id = 66});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A111", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B112", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C114", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D117", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1111", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1116", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1122", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1129", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1137", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1146", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(1, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(66, k1.PocoK_Id);
            Assert.Equal("K1166", k1.Name);
            Assert.Equal(80, k1.Value);
        }

        [Fact]
        public async Task MultipleFifteenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A151", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B152", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C154", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D157", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1511", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1516", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1522", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1529", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1537", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1546", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1556", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1567", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1579", m1.Name);
            Assert.Equal(93, m1.Value);

            // collectionN
            Assert.NotNull(record.CollectionN);
            var collectionN = record.CollectionN;
            Assert.NotNull(collectionN);
            Assert.True(collectionN.Any());
            Assert.Equal(14, collectionN.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var n1 = collectionN.First();
            Assert.NotNull(n1);
            Assert.Equal(92, n1.PocoN_Id);
            Assert.Equal("N1592", n1.Name);
            Assert.Equal(106, n1.Value);

            // collectionO
            Assert.NotNull(record.CollectionO);
            var collectionO = record.CollectionO;
            Assert.NotNull(collectionO);
            Assert.True(collectionO.Any());
            Assert.Equal(15, collectionO.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var o1 = collectionO.First();
            Assert.NotNull(o1);
            Assert.Equal(106, o1.PocoO_Id);
            Assert.Equal("O15106", o1.Name);
            Assert.Equal(120, o1.Value);
        }

        [Fact]
        public async Task MultipleFifteenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFifteenTypes, new {Id = 120});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A151", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B152", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C154", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D157", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1511", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1516", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1522", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1529", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1537", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1546", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1556", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1567", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1579", m1.Name);
            Assert.Equal(93, m1.Value);

            // collectionN
            Assert.NotNull(record.CollectionN);
            var collectionN = record.CollectionN;
            Assert.NotNull(collectionN);
            Assert.True(collectionN.Any());
            Assert.Equal(14, collectionN.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var n1 = collectionN.First();
            Assert.NotNull(n1);
            Assert.Equal(92, n1.PocoN_Id);
            Assert.Equal("N1592", n1.Name);
            Assert.Equal(106, n1.Value);

            // collectionO
            Assert.NotNull(record.CollectionO);
            var collectionO = record.CollectionO;
            Assert.NotNull(collectionO);
            Assert.True(collectionO.Any());
            Assert.Equal(1, collectionO.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var o1 = collectionO.First();
            Assert.NotNull(o1);
            Assert.Equal(120, o1.PocoO_Id);
            Assert.Equal("O15120", o1.Name);
            Assert.Equal(134, o1.Value);
        }

        [Fact]
        public async Task MultipleFiveTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFiveTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A51", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B52", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C54", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D57", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E511", e1.Name);
            Assert.Equal(25, e1.Value);
        }

        [Fact]
        public async Task MultipleFiveTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFiveTypes, new {Id = 15});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A51", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B52", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C54", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D57", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(1, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(15, e1.PocoE_Id);
            Assert.Equal("E515", e1.Name);
            Assert.Equal(29, e1.Value);
        }

        [Fact]
        public async Task MultipleFourteenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A141", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B142", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C144", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D147", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1411", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1416", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1422", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1429", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1437", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1446", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1456", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1467", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1479", m1.Name);
            Assert.Equal(93, m1.Value);

            // collectionN
            Assert.NotNull(record.CollectionN);
            var collectionN = record.CollectionN;
            Assert.NotNull(collectionN);
            Assert.True(collectionN.Any());
            Assert.Equal(14, collectionN.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var n1 = collectionN.First();
            Assert.NotNull(n1);
            Assert.Equal(92, n1.PocoN_Id);
            Assert.Equal("N1492", n1.Name);
            Assert.Equal(106, n1.Value);
        }

        [Fact]
        public async Task MultipleFourteenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFourteenTypes, new {Id = 105});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A141", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B142", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C144", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D147", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1411", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1416", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1422", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1429", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1437", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1446", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1456", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1467", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1479", m1.Name);
            Assert.Equal(93, m1.Value);

            // collectionN
            Assert.NotNull(record.CollectionN);
            var collectionN = record.CollectionN;
            Assert.NotNull(collectionN);
            Assert.True(collectionN.Any());
            Assert.Equal(1, collectionN.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var n1 = collectionN.First();
            Assert.NotNull(n1);
            Assert.Equal(105, n1.PocoN_Id);
            Assert.Equal("N14105", n1.Name);
            Assert.Equal(119, n1.Value);
        }

        [Fact]
        public async Task MultipleFourTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFourTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A41", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B42", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C44", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D47", d1.Name);
            Assert.Equal(21, d1.Value);
        }

        [Fact]
        public async Task MultipleFourTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithFourTypes, new {Id = 10});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A41", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B42", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C44", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(1, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(10, d1.PocoD_Id);
            Assert.Equal("D410", d1.Name);
            Assert.Equal(24, d1.Value);
        }

        [Fact]
        public async Task MultipleNineTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithNineTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A91", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B92", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C94", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D97", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E911", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F916", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G922", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H929", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I937", i1.Name);
            Assert.Equal(51, i1.Value);
        }

        [Fact]
        public async Task MultipleNineTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithNineTypes, new {Id = 45});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A91", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B92", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C94", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D97", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E911", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F916", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G922", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H929", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(1, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(45, i1.PocoI_Id);
            Assert.Equal("I945", i1.Name);
            Assert.Equal(59, i1.Value);
        }

        [Fact]
        public async Task MultipleOneTypeWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithOneType);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A11", a1.Name);
            Assert.Equal(15, a1.Value);
        }

        [Fact]
        public async Task MultipleSevenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithSevenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A71", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B72", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C74", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D77", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E711", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F716", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G722", g1.Name);
            Assert.Equal(36, g1.Value);
        }

        [Fact]
        public async Task MultipleSevenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithSevenTypes, new {Id = 28});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A71", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B72", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C74", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D77", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E711", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F716", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(1, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(28, g1.PocoG_Id);
            Assert.Equal("G728", g1.Name);
            Assert.Equal(42, g1.Value);
        }

        [Fact]
        public async Task MultipleSixteenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A161", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B162", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C164", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D167", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1611", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1616", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1622", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1629", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1637", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1646", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1656", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1667", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1679", m1.Name);
            Assert.Equal(93, m1.Value);

            // collectionN
            Assert.NotNull(record.CollectionN);
            var collectionN = record.CollectionN;
            Assert.NotNull(collectionN);
            Assert.True(collectionN.Any());
            Assert.Equal(14, collectionN.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var n1 = collectionN.First();
            Assert.NotNull(n1);
            Assert.Equal(92, n1.PocoN_Id);
            Assert.Equal("N1692", n1.Name);
            Assert.Equal(106, n1.Value);

            // collectionO
            Assert.NotNull(record.CollectionO);
            var collectionO = record.CollectionO;
            Assert.NotNull(collectionO);
            Assert.True(collectionO.Any());
            Assert.Equal(15, collectionO.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var o1 = collectionO.First();
            Assert.NotNull(o1);
            Assert.Equal(106, o1.PocoO_Id);
            Assert.Equal("O16106", o1.Name);
            Assert.Equal(120, o1.Value);

            // collectionP
            Assert.NotNull(record.CollectionP);
            var collectionP = record.CollectionP;
            Assert.NotNull(collectionP);
            Assert.True(collectionP.Any());
            Assert.Equal(16, collectionP.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var p1 = collectionP.First();
            Assert.NotNull(p1);
            Assert.Equal(121, p1.PocoP_Id);
            Assert.Equal("P16121", p1.Name);
            Assert.Equal(135, p1.Value);
        }

        [Fact]
        public async Task MultipleSixteenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithSixteenTypes, new {Id = 136});


            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A161", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B162", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C164", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D167", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1611", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1616", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1622", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1629", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1637", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1646", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1656", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1667", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1679", m1.Name);
            Assert.Equal(93, m1.Value);

            // collectionN
            Assert.NotNull(record.CollectionN);
            var collectionN = record.CollectionN;
            Assert.NotNull(collectionN);
            Assert.True(collectionN.Any());
            Assert.Equal(14, collectionN.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var n1 = collectionN.First();
            Assert.NotNull(n1);
            Assert.Equal(92, n1.PocoN_Id);
            Assert.Equal("N1692", n1.Name);
            Assert.Equal(106, n1.Value);

            // collectionO
            Assert.NotNull(record.CollectionO);
            var collectionO = record.CollectionO;
            Assert.NotNull(collectionO);
            Assert.True(collectionO.Any());
            Assert.Equal(15, collectionO.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var o1 = collectionO.First();
            Assert.NotNull(o1);
            Assert.Equal(106, o1.PocoO_Id);
            Assert.Equal("O16106", o1.Name);
            Assert.Equal(120, o1.Value);

            // collectionP
            Assert.NotNull(record.CollectionP);
            var collectionP = record.CollectionP;
            Assert.NotNull(collectionP);
            Assert.True(collectionP.Any());
            Assert.Equal(1, collectionP.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var p1 = collectionP.First();
            Assert.NotNull(p1);
            Assert.Equal(136, p1.PocoP_Id);
            Assert.Equal("P16136", p1.Name);
            Assert.Equal(150, p1.Value);
        }

        [Fact]
        public async Task MultipleSixTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithSixTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A61", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B62", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C64", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D67", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E611", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F616", f1.Name);
            Assert.Equal(30, f1.Value);
        }

        [Fact]
        public async Task MultipleSixTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithSixTypes, new {Id = 21});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A61", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B62", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C64", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D67", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E611", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(1, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(21, f1.PocoF_Id);
            Assert.Equal("F621", f1.Name);
            Assert.Equal(35, f1.Value);
        }

        [Fact]
        public async Task MultipleTenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithTenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A101", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B102", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C104", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D107", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1011", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1016", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1022", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1029", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1037", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1046", j1.Name);
            Assert.Equal(60, j1.Value);
        }

        [Fact]
        public async Task MultipleTenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithTenTypes, new {Id = 55});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A101", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B102", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C104", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D107", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1011", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1016", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1022", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1029", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1037", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(1, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(55, j1.PocoJ_Id);
            Assert.Equal("J1055", j1.Name);
            Assert.Equal(69, j1.Value);
        }

        [Fact]
        public async Task MultipleThirteenTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A131", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B132", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C134", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D137", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1311", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1316", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1322", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1329", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1337", i1.Name); // yes. yes, i am. (boom!)
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1346", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1356", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1367", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(13, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(79, m1.PocoM_Id);
            Assert.Equal("M1379", m1.Name);
            Assert.Equal(93, m1.Value);
        }

        [Fact]
        public async Task MultipleThirteenTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithThirteenTypes, new {Id = 91});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A131", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B132", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C134", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D137", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1311", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1316", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1322", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1329", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1337", i1.Name); // yes. yes, i am. (boom!)
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1346", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1356", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1367", l1.Name);
            Assert.Equal(81, l1.Value);

            // collectionM
            Assert.NotNull(record.CollectionM);
            var collectionM = record.CollectionM;
            Assert.NotNull(collectionM);
            Assert.True(collectionM.Any());
            Assert.Equal(1, collectionM.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var m1 = collectionM.First();
            Assert.NotNull(m1);
            Assert.Equal(91, m1.PocoM_Id);
            Assert.Equal("M1391", m1.Name);
            Assert.Equal(105, m1.Value);
        }

        [Fact]
        public async Task MultipleThreeTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithThreeTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A31", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B32", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C34", c1.Name);
            Assert.Equal(18, c1.Value);
        }

        [Fact]
        public async Task MultipleThreeTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithThreeTypes, new {Id = 6});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A31", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B32", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C34", c1.Name);
            Assert.Equal(18, c1.Value);
        }

        [Fact]
        public async Task MultipleTwelveTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A121", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B122", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C124", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D127", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1211", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1216", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1222", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1229", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1237", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1246", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1256", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(12, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(67, l1.PocoL_Id);
            Assert.Equal("L1267", l1.Name);
            Assert.Equal(81, l1.Value);
        }

        [Fact]
        public async Task MultipleTwelveTypesWithParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithTwelveTypes, new {Id = 78});

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A121", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B122", b1.Name);
            Assert.Equal(16, b1.Value);

            // collectionC
            Assert.NotNull(record.CollectionC);
            var collectionC = record.CollectionC;
            Assert.NotNull(collectionC);
            Assert.True(collectionC.Any());
            Assert.Equal(3, collectionC.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var c1 = collectionC.First();
            Assert.NotNull(b1);
            Assert.Equal(4, c1.PocoC_Id);
            Assert.Equal("C124", c1.Name);
            Assert.Equal(18, c1.Value);

            // collectionD
            Assert.NotNull(record.CollectionD);
            var collectionD = record.CollectionD;
            Assert.NotNull(collectionD);
            Assert.True(collectionD.Any());
            Assert.Equal(4, collectionD.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var d1 = collectionD.First();
            Assert.NotNull(d1);
            Assert.Equal(7, d1.PocoD_Id);
            Assert.Equal("D127", d1.Name);
            Assert.Equal(21, d1.Value);

            // collectionE
            Assert.NotNull(record.CollectionE);
            var collectionE = record.CollectionE;
            Assert.NotNull(collectionE);
            Assert.True(collectionE.Any());
            Assert.Equal(5, collectionE.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var e1 = collectionE.First();
            Assert.NotNull(e1);
            Assert.Equal(11, e1.PocoE_Id);
            Assert.Equal("E1211", e1.Name);
            Assert.Equal(25, e1.Value);

            // collectionF
            Assert.NotNull(record.CollectionF);
            var collectionF = record.CollectionF;
            Assert.NotNull(collectionF);
            Assert.True(collectionF.Any());
            Assert.Equal(6, collectionF.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var f1 = collectionF.First();
            Assert.NotNull(f1);
            Assert.Equal(16, f1.PocoF_Id);
            Assert.Equal("F1216", f1.Name);
            Assert.Equal(30, f1.Value);

            // collectionG
            Assert.NotNull(record.CollectionG);
            var collectionG = record.CollectionG;
            Assert.NotNull(collectionG);
            Assert.True(collectionG.Any());
            Assert.Equal(7, collectionG.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var g1 = collectionG.First();
            Assert.NotNull(g1);
            Assert.Equal(22, g1.PocoG_Id);
            Assert.Equal("G1222", g1.Name);
            Assert.Equal(36, g1.Value);

            // collectionH
            Assert.NotNull(record.CollectionH);
            var collectionH = record.CollectionH;
            Assert.NotNull(collectionH);
            Assert.True(collectionH.Any());
            Assert.Equal(8, collectionH.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var h1 = collectionH.First();
            Assert.NotNull(h1);
            Assert.Equal(29, h1.PocoH_Id);
            Assert.Equal("H1229", h1.Name);
            Assert.Equal(43, h1.Value);

            // collectionI
            Assert.NotNull(record.CollectionI);
            var collectionI = record.CollectionI;
            Assert.NotNull(collectionI);
            Assert.True(collectionI.Any());
            Assert.Equal(9, collectionI.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var i1 = collectionI.First();
            Assert.NotNull(i1);
            Assert.Equal(37, i1.PocoI_Id);
            Assert.Equal("I1237", i1.Name);
            Assert.Equal(51, i1.Value);

            // collectionJ
            Assert.NotNull(record.CollectionJ);
            var collectionJ = record.CollectionJ;
            Assert.NotNull(collectionJ);
            Assert.True(collectionJ.Any());
            Assert.Equal(10, collectionJ.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var j1 = collectionJ.First();
            Assert.NotNull(j1);
            Assert.Equal(46, j1.PocoJ_Id);
            Assert.Equal("J1246", j1.Name);
            Assert.Equal(60, j1.Value);

            // collectionK
            Assert.NotNull(record.CollectionK);
            var collectionK = record.CollectionK;
            Assert.NotNull(collectionK);
            Assert.True(collectionK.Any());
            Assert.Equal(11, collectionK.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var k1 = collectionK.First();
            Assert.NotNull(k1);
            Assert.Equal(56, k1.PocoK_Id);
            Assert.Equal("K1256", k1.Name);
            Assert.Equal(70, k1.Value);

            // collectionL
            Assert.NotNull(record.CollectionL);
            var collectionL = record.CollectionL;
            Assert.NotNull(collectionL);
            Assert.True(collectionL.Any());
            Assert.Equal(1, collectionL.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var l1 = collectionL.First();
            Assert.NotNull(l1);
            Assert.Equal(78, l1.PocoL_Id);
            Assert.Equal("L1278", l1.Name);
            Assert.Equal(92, l1.Value);
        }

        [Fact]
        public async Task MultipleTwoTypesWithNoParameters()
        {
            var result = await _commander.QueryAsync(Map.Query.Multiple.WithTwoTypes);

            var record = result.First();
            Assert.NotNull(record);

            // collectionA
            Assert.NotNull(record.CollectionA);
            var collectionA = record.CollectionA;
            Assert.NotNull(collectionA);
            Assert.True(collectionA.Any());
            Assert.Equal(1, collectionA.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var a1 = collectionA.First();
            Assert.NotNull(a1);
            Assert.Equal(1, a1.PocoA_Id);
            Assert.Equal("A21", a1.Name);
            Assert.Equal(15, a1.Value);

            // collectionB
            Assert.NotNull(record.CollectionB);
            var collectionB = record.CollectionB;
            Assert.NotNull(collectionB);
            Assert.True(collectionB.Any());
            Assert.Equal(2, collectionB.Count());

            // evaluate first result (way too much mission to evaluate all of them). 
            var b1 = collectionB.First();
            Assert.NotNull(b1);
            Assert.Equal(2, b1.PocoB_Id);
            Assert.Equal("B22", b1.Name); // rock lobstaaa! 
            Assert.Equal(16, b1.Value);
        }
    }
}