using System;

namespace Exercise305_OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = new Time()
            {
                Hours = 10, Minutes = 40
            };
            var time2 = new Time()
            {
                Hours = 1,
                Minutes = 10
            };




            var time3 = time1 + time2;

            Console.WriteLine(time3.ToString());
            
            time3 += 10;


            Console.WriteLine(time3.ToString());


        }
    }
}
