using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace SpaceSim
{
    class StellarBody
    {
        int ID { get; }
        StellarBodyType BodyType { get; }
        int BodySize { get; }

        Resource NaturalProduct { get; }
        int NaturalProductProduced { get; }
        int ProductionQuality { get; }

        String Name { get; set; }

        bool Occupied { get; set; }
        int DevelopmentID { get; set; }
    }
}
