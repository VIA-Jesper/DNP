using System;

namespace Exercise306_TernaryOperator_ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 42;
            string msg;


            msg = score > 1337 ? "This is a new highscore!" : "You need more points to beat the highscore";

            Console.WriteLine(msg);


        }
    }
}
