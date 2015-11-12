using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Input number: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n * n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 9);
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }
            Console.WriteLine("Sum = " + sum);
            int[,] matrix = new int[n, n];
            int counter = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, j] = arr[counter++];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

