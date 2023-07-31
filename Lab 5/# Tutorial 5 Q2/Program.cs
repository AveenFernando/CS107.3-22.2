using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_5_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] arr1 = new int[4];
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine("Input values: ");
                    arr1[i] = int.Parse(Console.ReadLine());
                }
                Array objarr1 = new Array();
                Console.WriteLine("Minimum value: " + objarr1.MinVal(arr1));
                Console.WriteLine("Maximum value: " + objarr1.MaxVal(arr1));
                Console.WriteLine("Average value: " + objarr1.Avg(arr1));
                Console.ReadLine();
        }
    }
}
