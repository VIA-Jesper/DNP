using System;

namespace Exercise208_Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun g1 = new Gun();
            Gun g2 = new Gun();
            Gun g3 = new Gun();
            Gun g4 = new Gun();
            Gun g5 = new Gun();
            Gun g6 = new Gun();
            Gun g7 = new Gun();




            g1.Shoot();
            g1.Shoot();
            g1.Shoot();
            g1.Shoot();

            g2.Shoot();
            g3.Shoot();
            g4.Shoot();



            Console.WriteLine(Gun.bulletCount);
            Console.WriteLine(g4.shotsFired);
        }
    }
}
