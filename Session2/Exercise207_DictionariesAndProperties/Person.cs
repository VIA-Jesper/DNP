using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise207_DictionariesAndProperties
{
    class Person
    {

        public string Name;
        public int Age;
        public string Power;

        public Person(string name, int i, string ability)
        {
            Name = name;
            Age = i;
            Power = ability;
        }

        public override string ToString()
        {
            return $"{Name} is {Age} old and has the ability of {Power}";
        }
    }
}
