//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.29 (21:39)
//  modified     : 2017.10.01 (20:40)
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