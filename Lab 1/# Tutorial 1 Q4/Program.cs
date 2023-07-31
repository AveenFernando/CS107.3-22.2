using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary: ");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Tax Rate:");
            double tax = double.Parse(Console.ReadLine());

            double newsal;

            newsal = sal - (sal * tax / 100);

            Console.WriteLine("New salary:" + newsal);
            Console.ReadLine();
        }
    }
}
