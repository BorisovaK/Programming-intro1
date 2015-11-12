using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is: ");
            Console.WriteLine(GetMaxNumber(GetMaxNumber(a, b), c));
        }
        private static int GetMaxNumber(int a, int b)
        { 
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
