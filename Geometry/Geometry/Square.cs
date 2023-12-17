using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Square : GeometricFigure, SimplePolygon
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; } = 4;
        public double[] SideLengths { get; set; } = new double[4];

        public Square(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException("Invalid value for side length.");
            }

            Base = sideLength;
            Height = sideLength; // For a square, height is the same as the side length
            for (int i = 0; i < 4; i++)
            {
                SideLengths[i] = sideLength;
            }
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return Base * Base;
        }

        private double CalculatePerimeter()
        {
            return 4 * Base;
        }

    }
}
