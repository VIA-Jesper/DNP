using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise303_GenericStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackInt = new Stack<int>();
            Stack<string>stackString = new Stack<string>();

            AddToStack(stackInt, new []{1,2,3,4});
            AddToStack(stackString, "val1", "val2","val3");

            stackInt.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            stackString.ToList().ForEach(i => Console.WriteLine(i.ToString()));



        }


        public static void AddToStack<T>(Stack<T> genericStack, params T[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                genericStack.Push(val[i]);
            }
        }
    }
}
