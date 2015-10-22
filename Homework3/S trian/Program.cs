using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_trian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the S of the triangle?");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine((a * h) / 2);

        }
    }
}
