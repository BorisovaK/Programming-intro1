﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0;

            Console.WriteLine("lowest");

            Console.WriteLine("input 1st number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input 2nd number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("input 3rd number");
            num3 = int.Parse(Console.ReadLine());


            int lowest = ((num1 < num2 ? num1 : num2) < num3 ?
                (num1 < num2 ? num1 : num2) : num3);
            int highest = ((num1 > num2 ? num1 : num2) > num3 ?
                (num1 > num2 ? num1 : num2) : num3);

            Console.WriteLine(" lowest is {0} ", lowest);
            Console.WriteLine(" highest is {0} ", highest);
            Console.ReadLine();

        }
    }
}