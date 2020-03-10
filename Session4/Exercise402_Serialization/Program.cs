using System;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


namespace Exercise402_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person("J", "H", 000000, DateTime.Parse("01-01-1980"));


            //SaveLoadFromFile(pers);
            SaveLoadFromJSON(pers);

        }


        private static void SaveLoadFromJSON(Person pers)
        {
            string JSON = JsonSerializer.Serialize(pers);

            Person deserializedPerson = JsonSerializer.Deserialize<Person>(JSON);

            Console.WriteLine(deserializedPerson.ToString());

        }


        private static void SaveLoadFromFile(Person pers)
        {
            // Create the file
            IFormatter provider = new BinaryFormatter();
            Stream stream = new FileStream("File.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            provider.Serialize(stream, pers);
            stream.Close();

            // load the file
            stream = new FileStream("File.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            var deserialised = (Person)provider.Deserialize(stream);
            stream.Close();


            // display the file
            Console.WriteLine(deserialised.ToString());
        }
    }


}
