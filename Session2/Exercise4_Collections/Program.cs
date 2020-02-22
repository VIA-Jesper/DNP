using System;
using System.Collections.Generic;

namespace Exercise4_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal("Elephant", 3000, 15),
                new Animal("Cheetah", 50, 120),
                new Animal("Golden eagle", 3, 320),
                new Animal("bird", 0.2, 42),
                new Animal("mouse", 0.8, 92),
                new Animal("rat", 3.9, 37),
                new Animal("weasel", 1.1, 66),
                new Animal("cat", 7.5, 67),
                new Animal("dog", 23.3, 8),
                new Animal("dog", 5.2, 12)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

            animals.Sort();


            
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
