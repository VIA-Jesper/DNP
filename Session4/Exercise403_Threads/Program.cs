using System;
using System.Threading;

namespace Exercise403_Threads
{
    class Program
    {


        static void Main(string[] args)
        {



            Reader r1 = new Reader("TextFile1.txt");
            Reader r2 = new Reader("TextFile2.txt");


            Thread t1 = new Thread(() => r1.Read());
            t1.Start();
            Thread t2 = new Thread(() => r2.Read());
            t2.Start();

            
            t1.Join();
            t2.Join();

            if (r1.Data.Length == r2.Data.Length)
            {
                Console.WriteLine(r1.Data.Equals(r2.Data) ? "The two files are equal" : "Files are not equal");
            }
            else
            {
                Console.WriteLine("The two files are not equal");
            }
        }

    }

  

}


        
