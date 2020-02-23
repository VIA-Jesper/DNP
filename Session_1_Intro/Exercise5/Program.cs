using System;

namespace Exercise105
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(args[0]);
            switch (number)
            {
                case 0:
                    Console.WriteLine("This if the first number");
                    break;
                case 10:
                    Console.WriteLine("This is the last number");
                    break;
                default:
                    if (number <= 10)
                    {
                        Console.WriteLine(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                    }

                    break;
            }
        }
    }
}
