using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_2_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Input number : ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The value is even number");
                }
                else
                {
                    Console.WriteLine("The  is odd number");
                }
            }

            Console.ReadLine();
        }
    }
}
