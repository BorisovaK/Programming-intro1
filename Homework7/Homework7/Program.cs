using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers are: ");
            int[,] matrix =
            {
                {1, 10, 15, 2},
                {5, 7, 24, 19},
                {8, 64, 32, 12},
                {89, 36, 17, 4}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.WriteLine(" " + matrix[i, j]);
                    }
                }
            }
        }
    }
}
