using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvennumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[] { 1, 2, 6, 8, 12, 15, 22, 13, 17, 11, 199, 10 };
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine("The sum of all even elements in the array is: " + sum);
            Console.ReadLine();
        }
    }
}
