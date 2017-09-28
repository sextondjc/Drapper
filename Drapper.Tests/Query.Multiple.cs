//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.28 (17:34)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Drapper.Tests.Models;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace Drapper.Tests
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public abstract partial class Query
    {
        [Fact]
        public void MultipleEightTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithEightTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);
        }

        [Fact]
        public void MultipleEightTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithEightTypes, new {Id = 36});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(50, h1.Value);
        }

        [Fact]
        public void MultipleElevenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithElevenTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);
        }

        [Fact]
        public void MultipleElevenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithElevenTypes, new {Id = 66});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(80, k1.Value);
        }

        [Fact]
        public void MultipleFifteenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFifteenTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);

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
            Equal(106, n1.Value);

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
            Equal(120, o1.Value);
        }

        [Fact]
        public void MultipleFifteenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFifteenTypes, new {Id = 120});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);

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
            Equal(106, n1.Value);

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
            Equal(134, o1.Value);
        }

        [Fact]
        public void MultipleFiveTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFiveTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);
        }

        [Fact]
        public void MultipleFiveTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFiveTypes, new {Id = 15});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(29, e1.Value);
        }

        [Fact]
        public void MultipleFourteenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFourteenTypes);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);

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
            Equal(106, n1.Value);
        }

        [Fact]
        public void MultipleFourteenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFourteenTypes, new {Id = 105});

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);

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
            Equal(119, n1.Value);
        }

        [Fact]
        public void MultipleFourTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFourTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);
        }

        [Fact]
        public void MultipleFourTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithFourTypes, new {Id = 10});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(24, d1.Value);
        }

        [Fact]
        public void MultipleNineTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithNineTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);
        }

        [Fact]
        public void MultipleNineTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithNineTypes, new {Id = 45});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(59, i1.Value);
        }

        [Fact]
        public void MultipleOneTypeWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithOneType);

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
            Equal(15, a1.Value);
        }

        [Fact]
        public void MultipleSevenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithSevenTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);
        }

        [Fact]
        public void MultipleSevenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithSevenTypes, new {Id = 28});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(42, g1.Value);
        }

        [Fact]
        public void MultipleSixteenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithSixteenTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);

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
            Equal(106, n1.Value);

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
            Equal(120, o1.Value);

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
            Equal(135, p1.Value);
        }

        [Fact]
        public void MultipleSixteenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithSixteenTypes, new {Id = 136});


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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);

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
            Equal(106, n1.Value);

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
            Equal(120, o1.Value);

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
            Equal(150, p1.Value);
        }

        [Fact]
        public void MultipleSixTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithSixTypes);

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
            Equal(15, a1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);
        }

        [Fact]
        public void MultipleSixTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithSixTypes, new {Id = 21});

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
            Equal(15, a1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(35, f1.Value);
        }

        [Fact]
        public void MultipleTenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithTenTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);
        }

        [Fact]
        public void MultipleTenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithTenTypes, new {Id = 55});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(69, j1.Value);
        }

        [Fact]
        public void MultipleThirteenTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithThirteenTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(93, m1.Value);
        }

        [Fact]
        public void MultipleThirteenTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithThirteenTypes, new {Id = 91});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);

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
            Equal(105, m1.Value);
        }

        [Fact]
        public void MultipleThreeTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithThreeTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);
        }

        [Fact]
        public void MultipleThreeTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithThreeTypes, new {Id = 6});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);
        }

        [Fact]
        public void MultipleTwelveTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithTwelveTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(81, l1.Value);
        }

        [Fact]
        public void MultipleTwelveTypesWithParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithTwelveTypes, new {Id = 78});

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);

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
            Equal(18, c1.Value);

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
            Equal(21, d1.Value);

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
            Equal(25, e1.Value);

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
            Equal(30, f1.Value);

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
            Equal(36, g1.Value);

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
            Equal(43, h1.Value);

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
            Equal(51, i1.Value);

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
            Equal(60, j1.Value);

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
            Equal(70, k1.Value);

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
            Equal(92, l1.Value);
        }

        [Fact]
        public void MultipleTwoTypesWithNoParameters()
        {
            var result = _commander.Query(Map.Query.Multiple.WithTwoTypes);

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
            Equal(15, a1.Value);

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
            Equal(16, b1.Value);
        }
    }
}