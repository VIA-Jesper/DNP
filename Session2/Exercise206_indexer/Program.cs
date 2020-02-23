using System;

namespace Exercise206_indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = new Schedule();
            schedule[new DateTime(2018, 9, 6)] = "DNP lessons";
            schedule[new DateTime(2018, 10, 6)] = "DNP lessons";

            schedule["2019-01-26"] = "DNP exam";
            schedule["2019-08-26"] = "DNP re-exam";

            System.Console.WriteLine(schedule["2018-09-06"]);
            System.Console.WriteLine(schedule[new DateTime(2019, 1, 26)]);
        }
    }
}
