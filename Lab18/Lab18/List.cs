using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab18
{
    class List
    {
        private int _count = 0;
        private readonly string[] _array;


        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }

        public bool RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                if (i > _array.Length)
                {
                    return false;
                }
                else _array[i] = _array[i + 1];
            }
            _count--;
            return true;
        }

        public void PrintReverse()
        {

            string[] x = _array;
            Array.Reverse(x);
            foreach (string i in x)
            {
                Console.Write(i + " ");
            }
        }

        public bool InsertAt(int index, string o)
        {
            for (int i = index; i < _array.Length; i++)
            {
                if (i == index)
                {
                    _array[i] = o;
                    return true;
                }                
            }
            _count++;
            return false;
        } 

    }
}
