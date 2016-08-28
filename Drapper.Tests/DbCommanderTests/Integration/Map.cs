// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    internal sealed partial class Map
    {
        public static Func<MultiMapPocoA, PocoA, MultiMapPocoA> WithTwoParameters = (multi, pocoA) =>
        {
            multi.PocoA = pocoA;
            return multi;
        };

        public static Func<PocoA, PocoB, MultiMapPocoB> WithTwoDistinctParameters = (pocoA, pocoB) =>
        {
            return new MultiMapPocoB
            {
                PocoA = pocoA,
                PocoB = pocoB
            };
        };
                
        internal sealed class Query
        {
            internal sealed class Multimap
            {
                public static Func<MultiMapPocoA, PocoA, MultiMapPocoA> WithTwoParameters = (multi, pocoA) =>
                {
                    multi.PocoA = pocoA;
                    return multi;
                };

                public static Func<PocoA, PocoB, MultiMapPocoB> WithTwoDistinctParameters = (pocoA, pocoB) =>
                {
                    return new MultiMapPocoB
                    {
                        PocoA = pocoA,
                        PocoB = pocoB
                    };
                };

                public static Func<MultiMapPocoB, PocoA, PocoB, MultiMapPocoB> WithThreeParameters = (multi, pocoA, pocoB) =>
                {
                    multi.PocoA = pocoA;
                    multi.PocoB = pocoB;
                    return multi;
                };

                public static Func<MultiMapPocoC, PocoA, PocoB, PocoC, MultiMapPocoC> WithFourParameters = (multi, pocoA, pocoB, pocoC) =>
                {
                    multi.PocoA = pocoA;
                    multi.PocoB = pocoB;
                    multi.PocoC = pocoC;
                    return multi;
                };

                public static Func<MultiMapPocoD, PocoA, PocoB, PocoC, PocoD, MultiMapPocoD> WithFiveParameters = (multi, pocoA, pocoB, pocoC, pocoD) =>
                {
                    multi.PocoA = pocoA;
                    multi.PocoB = pocoB;
                    multi.PocoC = pocoC;
                    multi.PocoD = pocoD;
                    return multi;
                };

                public static Func<MultiMapPocoE, PocoA, PocoB, PocoC, PocoD, PocoE, MultiMapPocoE> WithSixParameters = (multi, pocoA, pocoB, pocoC, pocoD, pocoE) =>
                {
                    multi.PocoA = pocoA;
                    multi.PocoB = pocoB;
                    multi.PocoC = pocoC;
                    multi.PocoD = pocoD;
                    multi.PocoE = pocoE;
                    return multi;
                };

                public static Func<MultiMapPocoF, PocoA, PocoB, PocoC, PocoD, PocoE, PocoF, MultiMapPocoF> WithSevenParameters = (multi, pocoA, pocoB, pocoC, pocoD, pocoE, pocoF) =>
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

            internal sealed class Multiple
            {
                public static Func<IEnumerable<PocoA>,
                    IEnumerable<CollectionPocoA>> WithOneType = (a) =>
                    {
                        return new List<CollectionPocoA>
                        {
                            new CollectionPocoA
                            {
                                CollectionA = a
                            }
                        };
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<CollectionPocoB>> WithTwoTypes = (a, b) =>
                    {
                        return new List<CollectionPocoB>
                        {
                            new CollectionPocoB
                            {
                                CollectionA = a,
                                CollectionB = b
                            }
                        };
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<CollectionPocoC>> WithThreeTypes = (a, b, c) =>
                    {
                        return new List<CollectionPocoC>
                        {
                            new CollectionPocoC
                            {
                                CollectionA = a,
                                CollectionB = b,
                                CollectionC = c
                            }
                        };
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<CollectionPocoD>> WithFourTypes = (a, b, c, d) =>
                    {
                        return new List<CollectionPocoD>
                        {
                            new CollectionPocoD
                            {
                                CollectionA = a,
                                CollectionB = b,
                                CollectionC = c,
                                CollectionD = d
                            }
                        };
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<CollectionPocoE>> WithFiveTypes = (a, b, c, d, e) =>
                    {
                        return new List<CollectionPocoE>
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
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<CollectionPocoF>> WithSixTypes = (a, b, c, d, e, f) =>
                    {
                        return new List<CollectionPocoF>
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
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<CollectionPocoG>> WithSevenTypes = (a, b, c, d, e, f, g) =>
                    {
                        return new List<CollectionPocoG>
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
                    };

                public static Func<IEnumerable<PocoA>,
                    IEnumerable<PocoB>,
                    IEnumerable<PocoC>,
                    IEnumerable<PocoD>,
                    IEnumerable<PocoE>,
                    IEnumerable<PocoF>,
                    IEnumerable<PocoG>,
                    IEnumerable<PocoH>,
                    IEnumerable<CollectionPocoH>> WithEightTypes = (a, b, c, d, e, f, g, h) =>
                    {
                        return new List<CollectionPocoH>
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
                    {
                        return new List<CollectionPocoI>
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
                    {
                        return new List<CollectionPocoJ>
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
                    {
                        return new List<CollectionPocoK>
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
                    {
                        return new List<CollectionPocoL>
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
                    {
                        return new List<CollectionPocoM>
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
                    {
                        return new List<CollectionPocoN>
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
                    {
                        return new List<CollectionPocoO>
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
                    {
                        return new List<CollectionPocoP>
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
                    };
            }            
        }
    }
}
