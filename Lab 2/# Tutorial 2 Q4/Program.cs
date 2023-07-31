using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_2_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value: ");
            int val = int.Parse(Console.ReadLine());

            if (val % 2 == 0)
            {
                Console.WriteLine("The value is a even number");
            }
            else
            {
                Console.WriteLine("The value is a odd number");
            }

            Console.ReadLine();
        }
    }
}
