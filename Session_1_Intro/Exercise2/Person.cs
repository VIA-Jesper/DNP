﻿using System;

namespace Exercise3
{
    class Person
    {
        private string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is: {Name}");
        }


    }
}
