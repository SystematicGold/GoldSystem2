using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Categories
    {
        public long Id { get; set; }
        public long Code { get; set; } = 0;
        public string? BarCode { get; set; }
        public string? Name { get; set; }
        public string? Kart { get; set; }
        public float Weight { get; set; } = 0;
        public float Making { get; set; } = 0;
        public float Cost { get; set; } = 0;
        public float CostPerGram { get; set; } = 0;
        public string? MadeIn { get; set; }
        public string? Supplier { get; set; }
        public int? NumberPieces { get; set; } = 0;
        public byte[]? Photo { get; set; }
        public int Type { get; set; }
    }
}