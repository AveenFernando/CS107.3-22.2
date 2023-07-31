using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_3_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value: ");
            int val = int.Parse(Console.ReadLine());

            if (val % 2 == 0)
            {
                Console.WriteLine("The value is even number");
            }
            else
            {
                Console.WriteLine("The value is odd number");
            }

            Console.ReadLine();
        }
    }
}
