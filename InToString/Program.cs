using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToString
{
    class Program
    {
        public static bool quit = false;
        public static String input;
        public static string output;
        public static string neg = "Negative ";
        public static string teen = "teen";
        public static string ty = "ty ";
        public static string hundred = " Hundred ";
        public static string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"};
        public static string[] prefix = { "", "", "Twen", "Thir", "Four", "Fif", "Six", "Seven", "Eigh", "Nine"};

        static void Main(string[] args)
        {
            while (!quit)
            {
                Console.WriteLine("Please enter a number between -1299 and 1299.");
                input = Console.ReadLine();
                try {
                    Console.WriteLine(Test(int.Parse(input)));
                } catch {
                    quit = !quit;
                }
            }
        }

        public static string Test(int i)
        {
            if (i < 0) {
                output = neg;
                i = -i;
            } else {
                output = "";
            }
            if (i == 0)
            {
                output += "Zero";
            }
            if (i > -1300 && i < 1300) {
                if ((i / 100) > 0) {
                    output += ones[(i / 100)] + hundred;
                }
                if ((i % 100) < 13)
                {
                    output += ones[(i % 100)];
                }
                else if ((i % 100) < 20)
                {
                    output += prefix[((i % 100) % 10)] + teen;
                }
                else if ((i % 100) < 100)
                {
                    output += prefix[((i % 100) / 10)] + ty;
                    if ((i % 10) != 0)
                    {
                        output += ones[(i % 10)];
                    }
                }
            } else {
                output = "i is out of bounds";
            }
            return output;
        }
    }
}
