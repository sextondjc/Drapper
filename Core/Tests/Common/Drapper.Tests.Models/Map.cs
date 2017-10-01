//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:39)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace Drapper.Tests.Models
{
    public static class Map
    {
        public static class Query
        {
            public static class Multimap
            {
                public static readonly Func<MultiMapPocoA, PocoA, MultiMapPocoA> WithTwoParameters = (multi, pocoA) =>
                {
                    multi.PocoA = pocoA;
                    return multi;
                };

                public static Func<IEnumerable<ComplexPocoB>, IEnumerable<PocoB>, IEnumerable<ComplexPocoB>>
                    ComplexWithTwoParameters2 = (complex, collection) =>
                    {
                        var complexPocoBs = complex as ComplexPocoB[] ?? complex.ToArray();
                        foreach (var item in complexPocoBs)
                        {
                            var pocoBs = collection as PocoB[] ?? collection.ToArray();
                            item.CollectionB = pocoBs.Where(x => x.PocoB_Id == item.Id);
                        }

                        return complexPocoBs;
                    };

                public static Func<PocoA, PocoB, MultiMapPocoB> WithTwoDistinctParameters = (pocoA, pocoB) =>
                    new MultiMapPocoB
                    {
                        PocoA = pocoA,
                        PocoB = pocoB
                    };

                public static readonly Func<MultiMapPocoB, PocoA, PocoB, MultiMapPocoB> WithThreeParameters =
                    (multi, pocoA, pocoB) =>
                    {
                        multi.PocoA = pocoA;
                        multi.PocoB = pocoB;
                        return multi;
                    };

                public static readonly Func<MultiMapPocoC, PocoA, PocoB, PocoC, MultiMapPocoC> WithFourParameters =
                    (multi, pocoA, pocoB, pocoC) =>
                    {
                        multi.PocoA = pocoA;
                        multi.PocoB = pocoB;
                        multi.PocoC = pocoC;
                        return multi;
                    };

                public static readonly Func<MultiMapPocoD, PocoA, PocoB, PocoC, PocoD, MultiMapPocoD> WithFiveParameters
                    = (multi, pocoA, pocoB, pocoC, pocoD) =>
                    {
                        multi.PocoA = pocoA;
                        multi.PocoB = pocoB;
                        multi.PocoC = pocoC;
                        multi.PocoD = pocoD;
                        return multi;
                    };

                public static readonly Func<MultiMapPocoE, PocoA, PocoB, PocoC, PocoD, PocoE, MultiMapPocoE>
                    WithSixParameters = (multi, pocoA, pocoB, pocoC, pocoD, pocoE) =>
                    {
                        multi.PocoA = pocoA;
                        multi.PocoB = pocoB;
                        multi.PocoC = pocoC;
                        multi.PocoD = pocoD;
                        multi.PocoE = pocoE;
                        return multi;
                    };

                public static Func<MultiMapPocoF, PocoA, PocoB, PocoC, PocoD, PocoE, PocoF, MultiMapPocoF>
                    WithSevenParameters = (multi, pocoA, pocoB, pocoC, pocoD, pocoE, pocoF) =>
                    {
                        multi.PocoA = pocoA;
                        multi.PocoB = pocoB;
                        multi.PocoC = pocoC;
                        multi.PocoD = pocoD;
                        multi.PocoE = pocoE;
                        multi.PocoF = pocoF;
                        return multi;
                    };
            }

            public static class Multiple
            {
                public static Func<IEnumerable<PocoA>,
                    IEnumerable<CollectionPocoA>> WithOneType = (a) => new List<CollectionPocoA>
                {
                    new CollectionPocoA
                    {
                        CollectionA = a
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<CollectionPocoB>> WithTwoTypes = (a, b) => new List<CollectionPocoB>
                {
                    new CollectionPocoB
                    {
                        CollectionA = a,
                        CollectionB = b
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<CollectionPocoC>> WithThreeTypes = (a, b, c) => new List<CollectionPocoC>
                {
                    new CollectionPocoC
                    {
                        CollectionA = a,
                        CollectionB = b,
                        CollectionC = c
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<CollectionPocoD>> WithFourTypes = (a, b, c, d) => new List<CollectionPocoD>
                {
                    new CollectionPocoD
                    {
                        CollectionA = a,
                        CollectionB = b,
                        CollectionC = c,
                        CollectionD = d
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<CollectionPocoE>> WithFiveTypes = (a, b, c, d, e) => new List<CollectionPocoE>
                {
                    new CollectionPocoE
                    {
                        CollectionA = a,
                        CollectionB = b,
                        CollectionC = c,
                        CollectionD = d,
                        CollectionE = e
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<CollectionPocoF>> WithSixTypes = (a, b, c, d, e, f) => new List<CollectionPocoF>
                {
                    new CollectionPocoF
                    {
                        CollectionA = a,
                        CollectionB = b,
                        CollectionC = c,
                        CollectionD = d,
                        CollectionE = e,
                        CollectionF = f
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<CollectionPocoG>> WithSevenTypes = (a, b, c, d, e, f, g) => new List<CollectionPocoG>
                {
                    new CollectionPocoG
                    {
                        CollectionA = a,
                        CollectionB = b,
                        CollectionC = c,
                        CollectionD = d,
                        CollectionE = e,
                        CollectionF = f,
                        CollectionG = g
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<CollectionPocoH>> WithEightTypes = (a, b, c, d, e, f, g, h) => new List<CollectionPocoH>
                {
                    new CollectionPocoH
                    {
                        CollectionA = a,
                        CollectionB = b,
                        CollectionC = c,
                        CollectionD = d,
                        CollectionE = e,
                        CollectionF = f,
                        CollectionG = g,
                        CollectionH = h
                    }
                };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<CollectionPocoI>> WithNineTypes = (a, b, c, d, e, f, g, h, i) =>
                    new List<CollectionPocoI>
                    {
                        new CollectionPocoI
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<CollectionPocoJ>> WithTenTypes = (a, b, c, d, e, f, g, h, i, j) =>
                    new List<CollectionPocoJ>
                    {
                        new CollectionPocoJ
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<PocoK>,
                    IEnumerable<CollectionPocoK>> WithElevenTypes = (a, b, c, d, e, f, g, h, i, j, k) =>
                    new List<CollectionPocoK>
                    {
                        new CollectionPocoK
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j,
                            CollectionK = k
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<PocoK>,
                    IEnumerable<PocoL>,
                    IEnumerable<CollectionPocoL>> WithTwelveTypes = (a, b, c, d, e, f, g, h, i, j, k, l) =>
                    new List<CollectionPocoL>
                    {
                        new CollectionPocoL
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j,
                            CollectionK = k,
                            CollectionL = l,
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<PocoK>,
                    IEnumerable<PocoL>,
                    IEnumerable<PocoM>,
                    IEnumerable<CollectionPocoM>> WithThirteenTypes = (a, b, c, d, e, f, g, h, i, j, k, l, m) =>
                    new List<CollectionPocoM>
                    {
                        new CollectionPocoM
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j,
                            CollectionK = k,
                            CollectionL = l,
                            CollectionM = m
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<PocoK>,
                    IEnumerable<PocoL>,
                    IEnumerable<PocoM>,
                    IEnumerable<PocoN>,
                    IEnumerable<CollectionPocoN>> WithFourteenTypes = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
                    new List<CollectionPocoN>
                    {
                        new CollectionPocoN
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j,
                            CollectionK = k,
                            CollectionL = l,
                            CollectionM = m,
                            CollectionN = n
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<PocoK>,
                    IEnumerable<PocoL>,
                    IEnumerable<PocoM>,
                    IEnumerable<PocoN>,
                    IEnumerable<PocoO>,
                    IEnumerable<CollectionPocoO>> WithFifteenTypes = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
                    new List<CollectionPocoO>
                    {
                        new CollectionPocoO
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j,
                            CollectionK = k,
                            CollectionL = l,
                            CollectionM = m,
                            CollectionN = n,
                            CollectionO = o
                        }
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<PocoI>,
                    IEnumerable<PocoJ>,
                    IEnumerable<PocoK>,
                    IEnumerable<PocoL>,
                    IEnumerable<PocoM>,
                    IEnumerable<PocoN>,
                    IEnumerable<PocoO>,
                    IEnumerable<PocoP>,
                    IEnumerable<CollectionPocoP>> WithSixteenTypes = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
                    new List<CollectionPocoP>
                    {
                        new CollectionPocoP
                        {
                            CollectionA = a,
                            CollectionB = b,
                            CollectionC = c,
                            CollectionD = d,
                            CollectionE = e,
                            CollectionF = f,
                            CollectionG = g,
                            CollectionH = h,
                            CollectionI = i,
                            CollectionJ = j,
                            CollectionK = k,
                            CollectionL = l,
                            CollectionM = m,
                            CollectionN = n,
                            CollectionO = o,
                            CollectionP = p
                        }
                    };
            }
        }
    }
}