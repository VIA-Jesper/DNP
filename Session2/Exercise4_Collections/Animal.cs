using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4_Collections
{
    class Animal : IComparable<Animal>
    {

        private string Type;
        private double Weight;
        private int Speed;

        public Animal(string Type, double Weight, int Speed)
        {
            this.Type = Type;
            this.Weight = Weight;
            this.Speed = Speed;
        }



        public override string ToString()
        {
            return $"{Type} weights {Weight} kg and can run {Speed} kmph";
        }

        public int CompareTo(Animal other)
        {
            return this.Speed.CompareTo(other.Speed);
        }
    }
}
