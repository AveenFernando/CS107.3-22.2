using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value 1:");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Value 2:");
            int val2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + (val1 + val2));
            Console.WriteLine("Subtraction: " + (val1 - val2));
            Console.WriteLine("Multiplication: " + (val1 * val2));
            Console.WriteLine("Division: " + (val1 / val2));

            Console.ReadLine();
        }
    }
}
