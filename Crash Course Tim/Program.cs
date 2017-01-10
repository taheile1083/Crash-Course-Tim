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
            //int year = 2017;
            //bool booring = true;
            //double pie = 6.283184;
            //char punc = '!';
            //string world = "Hello, World";
            //Console.WriteLine("The value of char punc is" + punc);
            //Console.WriteLine("The value of string world is: " + world +punc);
            //Console.WriteLine("The value of int year is: " + year + punc);
            //Console.WriteLine("The value of bool booring is: " + booring + punc);
            //Console.WriteLine("The value of double pie is: " + pie + punc);
            //Console.WriteLine("Select a number 1, 2, or 3.");
            //string snum = Console.ReadLine();
            //int inum = Convert.ToInt32(snum);
            //if (inum == 1) {
            //    Console.WriteLine("You Win!");
            //} else {
            //    Console.WriteLine("You Lose!");
            //}
            //Console.Read();

            int fizz;
            int buzz;
            string output;
            for (int i = 1; i <= 100; i++)
            {
                fizz = i % 3;
                buzz = i % 5;
                output = i.ToString();
                if (fizz == 0)
                {
                    output = "Fizz";
                    if (buzz == 0)
                    {
                        output += "Buzz";
                    }
                }
                else if (buzz == 0)
                {
                    output = "Buzz";
                }
                Console.WriteLine(output + "!");
            }
            Console.Read();
        }
    }
}
