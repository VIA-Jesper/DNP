using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise302_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> list = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                list.Add("Item #" + i);
            }

            list.ToList().ForEach(i => Console.WriteLine(i.ToString()));


            Console.WriteLine(" --- --- -- Random element -- --- ---");
            Console.WriteLine(list.GetRandomElement());

            Console.WriteLine(" --- --- -- shuffle list -- --- ---");
            list.ShuffleList();
            list.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }
    }
}
