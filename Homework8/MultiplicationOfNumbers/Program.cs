using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(0, 100);
                int b = rand.Next(0, 100);
                int c = rand.Next(0, 100);
                MultiplOfNumbers(a, b, c);

            }

        }
        public static void MultiplOfNumbers(int a, int b, int c)
        {
            Console.WriteLine("a * b *c = " + a + "*" + b + "*" + c + " = " + (a * b * c));
        }
    }
}
