using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolumeWebService.VolumeCalculator
{
    public class Calculator
    {

        public double CalculateVolumeCylinder(decimal height, decimal radius)
        {
            return Math.PI * Math.Pow((double) radius, 2) * (double) height;
        }

        public double CalculateVolumeCone(decimal height, decimal radius)
        {
            return (1d/3d) * Math.PI * Math.Pow((double) radius, 2) * (double) height;
        }

    }
}
