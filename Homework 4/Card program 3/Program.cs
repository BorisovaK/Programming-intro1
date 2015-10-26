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
            string card = (Console.ReadLine());
            switch (card)
            {
                case "2":
                    Console.WriteLine("The card is valid");
                    break;
                case "3":                   
                    Console.WriteLine("The card is valid");
                    break;
                case "4":                  
                    Console.WriteLine("The card is valid");
                    break;
                case "5":
                    Console.WriteLine("The card is valid");
                    break;
                case "6":
                    Console.WriteLine("The card is valid");
                    break;
                case "7":
                    Console.WriteLine("The card is valid");
                    break;
                case "8":
                    Console.WriteLine("The card is valid");
                    break;
                case "9":
                    Console.WriteLine("The card is valid");
                    break;
                case "10":
                    Console.WriteLine("The card is valid");
                    break;
                case "J":
                    Console.WriteLine("The card is valid");
                    break;
                case "Q":
                    Console.WriteLine("The card is valid");
                    break;
                case "K":
                    Console.WriteLine("The card is valid");
                    break;
                case "A":
                    Console.WriteLine("The card is valid");
                    break;
                default:
                    Console.WriteLine("The card is not valid");
                    break;
            }

        }
    }
}
