using System;
using System.Diagnostics;
using RestEngine;


namespace Exercise506_DownloadContent
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            RestEngine.Http http = new Http();
            var content = http.Request("https://www.via.dk").Result;


            stopwatch.Stop();


            Console.WriteLine(content);

            Console.WriteLine("Total time taken: " + stopwatch.Elapsed);

        }
    }
}
