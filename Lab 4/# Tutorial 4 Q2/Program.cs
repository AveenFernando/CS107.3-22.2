using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_4_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in km: ");
            double km = double.Parse(Console.ReadLine());

            Converter converter = new Converter();
            converter.KmToM(km);

            Console.ReadLine();
        }
    }
}
