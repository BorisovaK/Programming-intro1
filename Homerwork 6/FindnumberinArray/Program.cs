using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindnumberinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 5, 1, 5, 12, 543, 6, 5, 8, 9, 33 };
            Console.WriteLine("Please eneter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    Console.WriteLine("The index of the number " + number + " is: " + i);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
