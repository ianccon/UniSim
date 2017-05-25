using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace CivSim
{
    class Production
    {
        Product Product { get; }
        int Resource { get; }
        int Input { get; set; }

        public Production(Resource input, int maxProduced)
        {
            //Product = product;
            //MaxProduced = maxProduced;
        }
    }
}
