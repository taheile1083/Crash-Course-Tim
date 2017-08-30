using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffer<int> testbuffer = new Buffer<int>(5);
            for (int i = 0; i < 20; i++)
            {
                testbuffer.Write(i);
                Console.Write(testbuffer.ReadAt+"    ");
                Console.Write(testbuffer.WriteAt+"    ");
                Console.WriteLine(testbuffer.Read());
            }
            Console.Read();
        }
    }
}
