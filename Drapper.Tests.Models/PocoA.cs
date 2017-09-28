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