using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash_Course_Tim
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2017;
            bool booring = true;
            double pie = 6.283184;
            char punc = '!';
            string world = "Hello, World";
            Console.WriteLine("The value of char punc is" + punc);
            Console.WriteLine("The value of string world is: " + world +punc);
            Console.WriteLine("The value of int year is: " + year + punc);
            Console.WriteLine("The value of bool booring is: " + booring + punc);
            Console.WriteLine("The value of double pie is: " + pie + punc);
            Console.Read();
        }
    }
}
