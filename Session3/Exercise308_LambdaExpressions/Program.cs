using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise308_LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carParkOne = new List<Car>(){new Car("Black", 10, 5), new Car("Red", 11, 5.5), new Car("Blue", 8, 2)};


            var BlackCar = carParkOne.FindAll(x => x.Color == "Black");

            // print it
            BlackCar.ToList().ForEach(i => Console.WriteLine(i.ToString()));



            //particular color
            var foundCar = carParkOne.FindAll(x => String.Equals(x.Color, "Black", StringComparison.CurrentCultureIgnoreCase));
            foundCar.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            // engine size bigger than

            foundCar = carParkOne.FindAll(x => x.EngineSize >= 5);
            foundCar.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            // fuel lower than
            foundCar = carParkOne.FindAll(x => x.FuelEconomy < 10);
            foundCar.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            //condition combining 2 or more properties
            foundCar = carParkOne.FindAll(x => x.EngineSize <= 10 && x.FuelEconomy < 5.5);
            foundCar.ToList().ForEach(i => Console.WriteLine(i.ToString()));





        }
    }
}
