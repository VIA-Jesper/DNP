using System;

namespace Exercise301_MethodOverloading
{
    public class Player
    {


        public void Shout(string text)
        {
            Console.WriteLine(text);
        }

        public void Shout(int num)
        {
            Console.WriteLine($"{num} is my lucky number!");
        }

        public void Shout(Enemy enemy)
        {
            Console.WriteLine($"The enemy can do {enemy.Damage} damage to me.");
        }
    }

    public class Enemy
    {
        public int Damage;
    }
}