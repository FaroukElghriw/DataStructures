using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Operations
{
    internal class ArrayOPerations
    {
        public void Resize<T>( ref T[] Source , int newSize)
        {
            // must any fun have a Vaildations
            if (Source is null) return;
            if (newSize <= 0) return;
            if (Source.Length == newSize) return;
            T[] NewArray = new T[newSize];
            Buffer.BlockCopy(Source, 0, NewArray, 0, Buffer.ByteLength(Source)); // Buffer is faster than for loop is made for array 
             Source = NewArray;

        }
    }
}
