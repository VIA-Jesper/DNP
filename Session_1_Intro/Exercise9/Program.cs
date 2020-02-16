using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                StringUtility.SummarizeText(
                    "This is a string that is well above 20 char long and has to be summarized"));
        }
    }


    class StringUtility
    {
        public static string SummarizeText(string text)
        {
            if (text.Length > 20)
            {
                return text.Substring(0, 20).Insert(20, "[...]");
            }
            else
            {
                return text;
            }
        }
    }
}
