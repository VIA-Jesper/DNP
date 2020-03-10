using System;
using System.IO;

namespace Exercise401_Streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader("text.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error happened while reading or trying to...");
                throw;
            }


        }
    }
}
