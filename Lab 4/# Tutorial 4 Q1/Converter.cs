using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_4_Q1
{
    internal class Converter
    {
        public void KmToM()
        {
            Console.WriteLine("Enter distance in km:");
            double km = double.Parse(Console.ReadLine());

            double m = km * 1000;
            Console.WriteLine($"The distance in m: " + m);
        }
    }
}
