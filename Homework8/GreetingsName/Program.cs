using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingsName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = InputName();
            Console.WriteLine("Greetings, {0}!", name);
        }
        private static string InputName()
        {
            string name;
            Console.WriteLine("Write your name here: ");
            name = Console.ReadLine();
            return name;
        }
    }
}

