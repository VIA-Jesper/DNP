using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Exercise504_RestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello users!");


            var rest = new RestEngine.RestGetMethod();

            var result = rest.Request("https://jsonplaceholder.typicode.com/users").Result;
            var users = JsonConvert.DeserializeObject<List<Users>>(result, Converter.Settings);


            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.Name}, Email: {user.Email}");
            }


        }


        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        }
    }
}
