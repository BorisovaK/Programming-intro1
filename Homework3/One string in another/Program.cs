using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_string_in_another
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string that you want to check:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            bool z = y.Contains(x);
            Console.WriteLine(z);


                
                
                }
    }
}
