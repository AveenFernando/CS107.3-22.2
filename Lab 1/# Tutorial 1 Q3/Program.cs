using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input value 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input value 2:");
        int num2 = int.Parse(Console.ReadLine());

        int sum;

        sum = num1 + num2;

        Console.WriteLine("Sum:" + sum,);

        Console.ReadLine();
    }
}