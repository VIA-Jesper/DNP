using System;

namespace Exercise304_InterfaceAndGenerics
{
    public class Bomb : IExplodable<double>
    {

        public void Explode(double radius)
        {
            Console.WriteLine($"Boom! - Hitting a radius of {radius}.");
        }
    }
}