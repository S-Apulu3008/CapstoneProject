using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary
{
    public class Product
    {
        public int SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public int Units_On_Hand { get; set; }
    }
}
