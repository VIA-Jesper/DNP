using System;

namespace Exercise307_Delegates
{
    class Program
    {

        private delegate void Notifier(string s);

        static void Main(string[] args)
        {
            Notifier notifier = SayHello;
            notifier += SayGoodBye;


            notifier("DUDE");



        }


        private static void SayHello(string msg)
        {
            Console.WriteLine($"Hello {msg}");
        }

        private static void SayGoodBye(string msg)
        {
            Console.WriteLine($"Goodbye {msg}");
        }
    }
}
