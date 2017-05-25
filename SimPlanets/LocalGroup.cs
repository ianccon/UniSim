using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace SpaceSim
{
    class LocalGroup
    {
        private SolarSystem[,] localMap;

        public LocalGroup()
        {
            localMap = new SolarSystem[Settings.LocalGroupX,Settings.LocalGroupY];
            for(int i = 0; i < Settings.LocalGroupX; i++)
            {
                for (int j = 0; j < Settings.LocalGroupY; j++)
                {
                    localMap[i,j] = new SolarSystem(GenerateBodies(), );
                }
            }
        }

        private List<StellarBody> GenerateBodies()
        {
            return null;
        }
    }
}
