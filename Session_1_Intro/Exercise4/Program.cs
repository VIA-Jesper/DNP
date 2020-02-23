using System;

namespace Exercise104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even");
            
            for (int i = 0; i < 100; i++)
            {
                if (IsEven(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Odd");
            for (int i = 0; i < 100; i++)
            {
                if (!IsEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

    }
}
