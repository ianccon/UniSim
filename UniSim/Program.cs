using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace UniSim
{
    class Program
    {
        static void Main(string[] args)
        {
            NameMaker nm = new NameMaker();
            Console.WriteLine(nm.GenerateName(NameType.MINERALS));
            Console.ReadKey();
        }

    }
}
