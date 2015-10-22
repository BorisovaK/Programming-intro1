using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put your real number here");
            double x = double.Parse(Console.ReadLine());
            int y = 3;
            Console.WriteLine(x / y);

        }
    }
}
