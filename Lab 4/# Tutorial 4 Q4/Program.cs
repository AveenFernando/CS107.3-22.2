using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_4_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            Locator calculator = new Locator();
            double a = calculator.FindArea(r);
            double c = calculator.FindCircumference(r);
            Console.WriteLine("Area of the circle: " + a);
            Console.WriteLine("Circumference of the circle: " + c);
            Console.ReadLine();
        }
    }
}
