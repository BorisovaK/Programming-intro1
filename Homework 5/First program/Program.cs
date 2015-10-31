using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            int n = int.Parse(Console.ReadLine());
            while (y <= n)
            {
                Console.WriteLine(y);
                y++;
            }
        }
    }
}
