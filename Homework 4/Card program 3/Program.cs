using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What card did you chose?");
            int card = int.Parse(Console.ReadLine());
            switch (card)
            {
                case 2:
                    Console.WriteLine("The card is valid");
                    break;
                case 3:                   
                    Console.WriteLine("The card is valid");
                    break;
                case 4:                  
                    Console.WriteLine("The card is valid");
                    break;
                case 5:
                    Console.WriteLine("The card is valid");
                    break;
                case 6:
                    Console.WriteLine("The card is valid");
                    break;
                case 7:
                    Console.WriteLine("The card is valid");
                    break;
                case 8:
                    Console.WriteLine("The card is valid");
                    break;
                case 9:
                    Console.WriteLine("The card is valid");
                    break;
                case 10:
                    Console.WriteLine("The card is valid");
                    break;
                case 11:
                    string J = (Console.ReadLine());
                    Console.WriteLine("The card is valid");
                    break;
                case 12:
                    string Q = (Console.ReadLine());
                    Console.WriteLine("The card is valid");
                    break;
                case 13:
                    string K = (Console.ReadLine());
                    Console.WriteLine("The card is valid");
                    break;
                case 14:
                    string A = (Console.ReadLine());
                    Console.WriteLine("The card is valid");
                    break;
                default:
                    Console.WriteLine("The card is not valid");
                    break;
            }

        }
    }
}
