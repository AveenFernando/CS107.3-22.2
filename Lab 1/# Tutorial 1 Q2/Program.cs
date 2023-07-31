using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_1_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius");
            double rad = double.Parse(Console.ReadLine());
            double result;
            result = Math.PI * rad * rad;

            Console.WriteLine("Area: " + result);

            Console.ReadLine();
        }
    }
}
