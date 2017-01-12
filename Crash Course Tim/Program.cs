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
            //DoStuff();
            //DoStuff("Tim");
            //string greeting = Greeting("Tim");
            //Console.WriteLine(greeting);
            addBinary(1, 2);
            addBinary(1, 4);
            addBinary(1, 6);
            addBinary(1, 8);
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Red"));
            cars.Add(new Car("Blue"));
            cars.Add(new Car("Green"));
            cars.Add(new Car("Orange"));
            cars.Add(new Car("Black"));

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Describe());
            }
            Console.Read();
        }

        public static void DoStuff()
        {
            Console.WriteLine("Hello From DoStuff()");
        }

        public static void DoStuff(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static string Greeting(string name)
        {
            return "Hello " + name;
        }

        public static void addBinary(int a,int b)
        {
            int dec = (a + b);
            string bin = Convert.ToString(dec,2);
            //for (int i = dec; i > 0;)
            //{
            //    int x = dec % 2;
            //    bin = x.ToString() + bin;
            //    i = dec - (dec / 2);
            //}
            Console.WriteLine(bin);
        }
    }
}

//Data Types, Console I/O
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

//Fizz Buzz
//int fizz;
//int buzz;
//string output;
//for (int i = 1; i <= 100; i++)
//{
//    fizz = i % 3;
//    buzz = i % 5;
//    output = i.ToString();
//    if (fizz == 0)
//    {
//        output = "Fizz";
//        if (buzz == 0)
//        {
//            output += "Buzz";
//        }
//    }
//    else if (buzz == 0)
//    {
//        output = "Buzz";
//    }
//    Console.WriteLine(output + "!");
//}
//Console.Read();
