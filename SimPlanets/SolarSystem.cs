using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSim
{
    class SolarSystem
    {
        public string Name { get; set; }
        public List<StellarBody> Bodies { get; }

        public SolarSystem(List<StellarBody> bodies, string name)
        {
            Name = name;
            int i = 0;
            foreach(StellarBody body in bodies)
            {
                this.Bodies[i] = body;
                i++;
            }
        }
    }
}
