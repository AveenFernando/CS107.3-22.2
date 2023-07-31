using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_1 
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Input your name :");
                string name = Console.ReadLine();
                Console.WriteLine("Input your batch :");
                double batch = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Batch : " + batch);

                Console.ReadLine();
            }
    }
}
