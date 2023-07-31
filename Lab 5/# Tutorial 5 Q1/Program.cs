using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_5_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCal = new Calculator();
            Console.WriteLine("Enter 1 for + ");
            Console.WriteLine("Enter 2 for - ");
            Console.WriteLine("Enter 3 for * ");
            Console.WriteLine("Enter 4 for / ");

            Console.WriteLine("Enter function: ");
            int func = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value 2: ");
            double b = double.Parse(Console.ReadLine());

            switch (func)
            {
                case 1:
                    Console.WriteLine("Result: " + objCal.Addition(a, b));
                    break;
                case 2:
                    Console.WriteLine("Result: " + objCal.Subtraction(a, b));
                    break;
                case 3:
                    Console.WriteLine("Result: "+ objCal.Multiplication(a, b));
                    break;
                case 4:
                    Console.WriteLine("Result: " + objCal.Division(a, b));
                    break;
                default:
                    Console.WriteLine("Enter correct value: ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
