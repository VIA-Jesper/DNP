using System.Drawing;

namespace Exercise308_LambdaExpressions
{
    public class Car
    {
        public string Color;
        public int EngineSize;
        public double FuelEconomy;

        public Car(string color, int engineSize, double fuelEconomy)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
        }


        public override string ToString()
        {
            return $"Color: {Color}, Engine Size: {EngineSize}, Fuel Economy: {FuelEconomy}";
        }
    }
}