using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_4_Q2
{
    internal class Converter
    {
        public void KmToM(double kmVal)
        {
            double m = kmVal * 1000;
            Console.WriteLine($"The distance in m: " + m);
        }

    }
}
