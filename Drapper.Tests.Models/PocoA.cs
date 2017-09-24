using System;

namespace Drapper.Tests.Models
{
    public class PocoA
    {
        public int PocoAId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }

    public class PocoAImmutable
    {
        public int PocoAId { get; }
        public string Name { get; }
        public decimal Value { get;  }
        public DateTime Modified { get; }

        public PocoAImmutable(int pocoAId, string name, decimal value, DateTime modified)
        {
            PocoAId = pocoAId;
            Name = name;
            Value = value;
            Modified = modified;
        }
    }
}