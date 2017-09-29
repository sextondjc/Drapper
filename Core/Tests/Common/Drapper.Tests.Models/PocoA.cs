//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.24 (19:47)
//  modified     : 2017.09.28 (23:06)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;

namespace Drapper.Tests.Models
{
    public class PocoA
    {
        public int PocoA_Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }
}