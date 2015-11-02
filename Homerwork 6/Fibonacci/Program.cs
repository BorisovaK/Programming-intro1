using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the array: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] array = new int[length];
            int first = 0, second = 1, next, i;
            Console.WriteLine("The array with length " + length + " has the following elements: ");
            for (i = 0; i < length; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write(next + "  ");
            }
            Console.ReadLine();
        }
    }
}
