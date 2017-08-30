using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Buffer
{
    class Buffer<T>
    {
        public int Length { get; set; }
        public int ReadAt { get; set; }
        public int WriteAt { get; set; }
        public T[] BuffArr { get; set; }

        public Buffer(int L){
            Length = L;
            BuffArr = new T[Length];
        }

        public T Read()
        {
            T temp = BuffArr[ReadAt];
            if (ReadAt != WriteAt)
            {
                ReadAt = ((ReadAt + 1) % Length);
            }
            return temp;
        }
        public bool Write(T input)
        {
            if (((WriteAt + 1) % Length) != ReadAt)
            {
                BuffArr[WriteAt] = input;
                WriteAt = ((WriteAt + 1) % Length);
                return true;
            }
            else return false;
        }
    }
}
