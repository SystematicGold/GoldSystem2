using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class StoneItemCategories
    {
        public long Id { get; set; }
        public long CategoriesCode { get; set; } = 0;
        public long StoneCode { get; set; } = 0;
        public float Weight { get; set; } = 0;
        public string Colour { get; set; }
        public long Price { get; set; } = 0;
    }
}