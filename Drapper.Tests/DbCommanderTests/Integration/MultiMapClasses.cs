// ============================================================================================================================= 
// author           : david sexton (@sextondjc | sextondjc.com)
// date             : 2015.12.23
// licence          : licensed under the terms of the MIT license. See LICENSE.txt
// =============================================================================================================================
using System;
using System.Collections.Generic;

namespace Drapper.Tests.DbCommanderTests.Integration
{
    #region / query /

    public class PocoA
    {
        public int PocoA_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoB
    {
        public int PocoB_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoC
    {
        public int PocoC_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoD
    {
        public int PocoD_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoE
    {
        public int PocoE_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoF
    {
        public int PocoF_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoG
    {
        public int PocoG_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }

    public class PocoH
    {
        public int PocoH_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoI
    {
        public int PocoI_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoJ
    {
        public int PocoJ_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoK
    {
        public int PocoK_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoL
    {
        public int PocoL_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoM
    {
        public int PocoM_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoN
    {
        public int PocoN_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoO
    {
        public int PocoO_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }
    public class PocoP
    {
        public int PocoP_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; }
    }

    #endregion

    #region / multimap /

    public class MultiMapPocoA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }        
    }

    public class MultiMapPocoB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
    }

    public class MultiMapPocoC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
    }

    public class MultiMapPocoD
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
    }

    public class MultiMapPocoE
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
    }

    public class MultiMapPocoF
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }        
    }

    public class MultiMapPocoG
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
    }
    
    #endregion

    #region / query multiple /

    public class MultiplePocoA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        
        public IEnumerable<PocoA> CollectionA { get; set; }        
    }

    public class MultiplePocoB
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }        
    }

    public class MultiplePocoC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }        
    }

    public class MultiplePocoD
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }        
    }

    public class MultiplePocoE
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }        
    }

    public class MultiplePocoF
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }        
    }

    public class MultiplePocoG
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
    }

    #endregion

    #region / complex poco's /

    // NOTE: 
    // These POCO's aren't really "Complex", but their (secondary )intention is 
    // to demonstrate that it's possible to hydrate a POCO with properties made 
    // up of primitive types, complex types, and collections. 
    //
    // The individual mapping logic for real-world complex POCO's would be 
    // up to repository authors. 
    //
    // The PRIMARY intention of the classes below is to prove that the DbCommander
    // can handle these scenarios. 
        
    public class ComplexPocoA
    {
        // this is the exact same poco as MutliMapPocoA,
        // but it's used for a different purpose (hydrated by 
        // a query multiple, instead of a multimap)
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }        
    }

    public class ComplexPocoB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public PocoA PocoA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; } = new List<PocoB>();
    }

    public class ComplexPocoC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; } = new List<PocoC>();
    }

    public class ComplexPocoD
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; } = new List<PocoD>();
    }

    public class ComplexPocoE
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; } = new List<PocoE>();
    }

    public class ComplexPocoF
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; } = new List<PocoF>();
    }

    public class ComplexPocoG
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; } = new List<PocoG>();
    }

    public class ComplexPocoH
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; } = new List<PocoH>();
    }

    public class ComplexPocoI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; } = new List<PocoI>();
    }

    public class ComplexPocoJ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; } = new List<PocoJ>();        
    }

    public class ComplexPocoK
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public PocoJ PocoJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; } = new List<PocoK>();        
    }

    public class ComplexPocoL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public PocoJ PocoJ { get; set; }
        public PocoK PocoK { get; set; }
        public IEnumerable<PocoL> CollectionL { get; set; } = new List<PocoL>();        
    }

    public class ComplexPocoM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public PocoJ PocoJ { get; set; }
        public PocoK PocoK { get; set; }
        public PocoL PocoL { get; set; }
        public IEnumerable<PocoM> CollectionM { get; set; } = new List<PocoM>();        
    }

    public class ComplexPocoN
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public PocoJ PocoJ { get; set; }
        public PocoK PocoK { get; set; }
        public PocoL PocoL { get; set; }
        public PocoM PocoM { get; set; }
        public IEnumerable<PocoN> CollectionN { get; set; } = new List<PocoN>();        
    }

    public class ComplexPocoO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public PocoJ PocoJ { get; set; }
        public PocoK PocoK { get; set; }
        public PocoL PocoL { get; set; }
        public PocoM PocoM { get; set; }
        public PocoN PocoN { get; set; }
        public IEnumerable<PocoO> CollectionO { get; set; } = new List<PocoO>();        
    }


    public class ComplexPocoP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime Modified { get; set; }

        public PocoA PocoA { get; set; }
        public PocoB PocoB { get; set; }
        public PocoC PocoC { get; set; }
        public PocoD PocoD { get; set; }
        public PocoE PocoE { get; set; }
        public PocoF PocoF { get; set; }
        public PocoG PocoG { get; set; }
        public PocoH PocoH { get; set; }
        public PocoI PocoI { get; set; }
        public PocoJ PocoJ { get; set; }
        public PocoK PocoK { get; set; }
        public PocoL PocoL { get; set; }
        public PocoM PocoM { get; set; }
        public PocoN PocoN { get; set; }
        public PocoO PocoO { get; set; }
        public IEnumerable<PocoP> CollectionO { get; set; } = new List<PocoP>();
    }


    #endregion

    #region / collection pocos /

    public class CollectionPocoA
    {
        public IEnumerable<PocoA> CollectionA { get; set; }        
    }

    public class CollectionPocoB
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }        
    }

    public class CollectionPocoC
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }        
    }

    public class CollectionPocoD
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }        
    }

    public class CollectionPocoE
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }     
    }

    public class CollectionPocoF
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }     
    }

    public class CollectionPocoG
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }        
    }

    public class CollectionPocoH
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }        
    }

    public class CollectionPocoI
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }        
    }

    public class CollectionPocoJ
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }        
    }

    public class CollectionPocoK
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; }        
    }

    public class CollectionPocoL
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; }
        public IEnumerable<PocoL> CollectionL { get; set; }        
    }

    public class CollectionPocoM
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; }
        public IEnumerable<PocoL> CollectionL { get; set; }
        public IEnumerable<PocoM> CollectionM { get; set; }        
    }

    public class CollectionPocoN
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; }
        public IEnumerable<PocoL> CollectionL { get; set; }
        public IEnumerable<PocoM> CollectionM { get; set; }
        public IEnumerable<PocoN> CollectionN { get; set; }
    }
    
    public class CollectionPocoO
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; }
        public IEnumerable<PocoL> CollectionL { get; set; }
        public IEnumerable<PocoM> CollectionM { get; set; }
        public IEnumerable<PocoN> CollectionN { get; set; }
        public IEnumerable<PocoO> CollectionO { get; set; }        
    }

    public class CollectionPocoP
    {
        public IEnumerable<PocoA> CollectionA { get; set; }
        public IEnumerable<PocoB> CollectionB { get; set; }
        public IEnumerable<PocoC> CollectionC { get; set; }
        public IEnumerable<PocoD> CollectionD { get; set; }
        public IEnumerable<PocoE> CollectionE { get; set; }
        public IEnumerable<PocoF> CollectionF { get; set; }
        public IEnumerable<PocoG> CollectionG { get; set; }
        public IEnumerable<PocoH> CollectionH { get; set; }
        public IEnumerable<PocoI> CollectionI { get; set; }
        public IEnumerable<PocoJ> CollectionJ { get; set; }
        public IEnumerable<PocoK> CollectionK { get; set; }
        public IEnumerable<PocoL> CollectionL { get; set; }
        public IEnumerable<PocoM> CollectionM { get; set; }
        public IEnumerable<PocoN> CollectionN { get; set; }
        public IEnumerable<PocoO> CollectionO { get; set; }
        public IEnumerable<PocoP> CollectionP { get; set; }
    }

    public class ComplexPocoDeepGraph
    {
        // it's not really a deep graph, but it shows that 
        // adding a smattering of boogie to the Func<> passed
        // gives you the option of populating the properties of properties. 

        // 1st execution path (0 levels)
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        // 2nd path (1 level)
        public PocoA PocoA { get; set; }

        // 3rd path (1 level)
        public MultiMapPocoA MultimapPocoA { get; set; }                

        // 4th path (3 levels)
        public ComplexPocoB ComplexPocoB { get; set; }
    }

    #endregion
}
