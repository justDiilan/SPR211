using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Rectangle : GeometricFigure, SimplePolygon
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; } = 4;
        public double[] SideLengths { get; set; } = new double[4];

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Invalid values for length or width.");
            }

            Base = length;
            Height = width;
            for (int i = 0; i < 4; i++)
            {
                SideLengths[i] = (i % 2 == 0) ? length : width;
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
            return 2 * (Base + Height);
        }
    }
}
