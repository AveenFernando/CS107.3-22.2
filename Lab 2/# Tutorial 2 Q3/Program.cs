using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_2_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius:");
            double rad = double.Parse(Console.ReadLine());
            double circ;
            double area;
            circ = 2 * Math.PI * rad;
            area = Math.PI * rad * rad;

            Console.WriteLine("Area:" + area);
            Console.WriteLine("Circumference: " + circ);

            Console.ReadLine();
        }
    }
}
