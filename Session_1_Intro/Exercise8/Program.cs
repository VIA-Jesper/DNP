using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine(new string(name.Reverse().ToArray()));
            Console.Read();

        }
    }
}
