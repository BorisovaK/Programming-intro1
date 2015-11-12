using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTheNumberOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int a = int.Parse(Console.ReadLine());
            OddOrEven(a);
           
        }
        public static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Odd");
            }
            else
            {
                Console.WriteLine("The number is Even");
            }
        }
    }
}
