using System;

namespace Exercise107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.Parse(args[0]) > int.Parse(args[1]) ? args[0] : args[1]);
        }
    }
}
