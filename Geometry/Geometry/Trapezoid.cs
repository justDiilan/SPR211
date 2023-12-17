using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Trapezoid : GeometricFigure, SimplePolygon
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; } = 4;
        public double[] SideLengths { get; set; } = new double[4];

        public Trapezoid(double baseLength1, double baseLength2, double height, double side)
        {
            if (baseLength1 <= 0 || baseLength2 <= 0 || height <= 0 || side <= 0)
            {
                throw new ArgumentException("Invalid values for base lengths, height, or side.");
            }

            Base = baseLength1;
            Height = height;
            AngleBetweenBaseAndAdjacentSide = Math.Acos((baseLength1 - baseLength2) / (2 * side));
            SideLengths[0] = baseLength1;
            SideLengths[1] = baseLength2;
            SideLengths[2] = height;
            SideLengths[3] = side;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return 0.5 * (Base + SideLengths[2]) * Height;
        }

        private double CalculatePerimeter()
        {
            return Base + SideLengths[1] + SideLengths[2] + SideLengths[3];
        }
    }
}
