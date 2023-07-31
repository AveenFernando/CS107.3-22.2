using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_4_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter distance in km: ");
                double km = double.Parse(Console.ReadLine());
                Converter converter = new Converter();
                double meters = converter.KmToM(km);
                Console.WriteLine("Distance in m: " + meters);
                Console.ReadLine();
        }
    }
}
