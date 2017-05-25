using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSim
{
    class Development
    {
        int ID { get; }
        int CoordX { get; }
        int CoordY { get; }
        int BodyID { get; }


        int Population { get; set; }
        int DevelopmentPercentage { get; set; }
        Production Production { get; set; }
    }
}
