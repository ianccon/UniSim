using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class ProductSet
    {
        private List<Product> products;
        Product Resolve(ProductType type)
        {
            return products[(int)type];
        }
    }
}
