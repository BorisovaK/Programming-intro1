using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is Null");
                    break;
                case 1:
                    Console.WriteLine("The number is One");
                    break;
                case 2:
                    Console.WriteLine("The number is Two");
                    break;
                case 3:
                    Console.WriteLine("The number is Three");
                    break;
                case 4:
                    Console.WriteLine("The number is Four");
                    break;
                case 5:
                    Console.WriteLine("The number is Five");
                    break;
                case 6:
                    Console.WriteLine("The number is Six");
                    break;
                case 7:
                    Console.WriteLine("The number is Seven");
                    break;
                case 8:
                    Console.WriteLine("The number is Eight");
                    break;
                case 9:
                    Console.WriteLine("The number is Nine");
                    break;
                default:
                    Console.WriteLine("The number is not valid");
                    break;
            }


        }
    }
}
