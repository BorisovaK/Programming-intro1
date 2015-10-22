using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers and see the result");

            int q = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(q % m);
        }
    }
}
