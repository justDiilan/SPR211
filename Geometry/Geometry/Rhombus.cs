using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Rhombus : GeometricFigure, SimplePolygon
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; } = 4;
        public double[] SideLengths { get; set; } = new double[4];

        public Rhombus(double sideLength, double angle)
        {
            if (sideLength <= 0 || angle <= 0 || angle >= 180)
            {
                throw new ArgumentException("Invalid values for side length or angle.");
            }

            Base = sideLength;
            Height = sideLength;
            AngleBetweenBaseAndAdjacentSide = angle;
            for (int i = 0; i < 4; i++)
            {
                SideLengths[i] = sideLength;
            }
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return Base * Height;
        }

        private double CalculatePerimeter()
        {
            return 4 * Base;
        }
    }
}
