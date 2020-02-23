using System;
using System.Collections.Generic;

namespace Exercise207_DictionariesAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> dic = new Dictionary<string, Person>();


            Person person1 = new Person("Name 1", 20, "Invisibility");
            dic.Add("InviMan", person1);

            Person person2 = new Person("name 2", 345, "DiamondSkin");
            dic.Add("theRock", person2);



            Console.WriteLine(dic["InviMan"].ToString());
            Console.WriteLine(dic["theRock"].ToString());

        }
    }
}
