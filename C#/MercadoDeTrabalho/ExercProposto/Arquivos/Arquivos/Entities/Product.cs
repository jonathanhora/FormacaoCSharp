using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Unit { get; set; }

        public Product(string name, double price, int unit)
        {
            Name = name;
            Price = price;
            Unit = unit;
        }

        public double Total()
        {
            return Price * Unit;
        }
    }
}
