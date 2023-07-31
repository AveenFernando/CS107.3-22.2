using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_3_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value: ");
            int val = int.Parse(Console.ReadLine());
            for (int i = 1; i <= val; i += 2)
            {
                sum += i;
            }
            Console.Write("Sum of Odd numbers from 1: " + sum);
            Console.ReadLine();
        }
    }
}
