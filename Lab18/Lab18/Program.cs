using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {


            var list = new List(10);

            list.InsertAt(0, "hello ");
            list.InsertAt(1, "how "); 
            list.InsertAt(2, "are ");
            Console.WriteLine(list.InsertAt(3, "you?"));

            Console.WriteLine(list.InsertAt(13, "hello"));




            



        }
    }
}
