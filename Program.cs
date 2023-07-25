using System;
using System.Collections.Generic;

namespace DataStructure11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackD stackObj = new StackD();

            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);
            stackObj.Push(4);

            


            while (!stackObj.IsEmpty())

            {
                int element = stackObj.Pop();
                Console.WriteLine(element);
               
               element= stackObj.Pop();

               // Console.ReadLine();
            }
           //Console.ReadLine();

        }
    }
}
