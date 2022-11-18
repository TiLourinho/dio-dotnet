using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class MyArray<T>
    {
        private static int capacity = 10;
        private int counter = 0;
        private T[] array = new T[capacity];

        public void AddElement(T element)
        {
            if (counter + 1 < capacity + 1)
            {
                array[counter] = element;
            }

            counter++;
        }

        public T this[int index]
        {
            get { return array[index]; }

            set { array[index] = value; }
        }
    }
}