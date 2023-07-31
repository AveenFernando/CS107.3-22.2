using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_6_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the size of arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];

            Console.WriteLine("Enter values for array 1: ");
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter values for array 2: ");
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += arr1[i];
                scalarSum += arr2[i];
            }
            Console.WriteLine("Scalar Sum: " + scalarSum);

            int[] vectorSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = arr2[i] + arr2[i];
                Console.Write(vectorSum[i] + " ");
            }
            Console.WriteLine();

            int[] vectorResult = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorResult[i] = arr1[i] * arr2[i];
                Console.Write(vectorResult[i] + " ");
            }
            Console.WriteLine();

            int scalarResult = 0;
            for (int i = 0; i < size; i++)
            {
                scalarResult += arr1[i] * arr2[i];
            }
            Console.WriteLine("Scalar Result: " + scalarResult);

            Console.ReadLine();
        }
    }
}
