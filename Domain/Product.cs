using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public ProductType Type { get; }
        public string Name { get; }
        public int Value { get; set; }
        public Quality Quality {get;}
    }
}
