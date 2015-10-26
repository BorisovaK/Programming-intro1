using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your points in the console:");
            int points = int.Parse(Console.ReadLine());
            if (points >= 1 && points <= 3 )
            {
                Console.WriteLine(points * 5);
            }
            else if (points >= 4 && points <= 6)
            {
                Console.WriteLine(points * 10);
            }
            else if (points >= 7 && points <= 9)
            {
                Console.WriteLine(points * 50);
            }
        }
    }
}
