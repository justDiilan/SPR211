using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Parallelogram : GeometricFigure, SimplePolygon
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; } = 4;
        public double[] SideLengths { get; set; } = new double[4];

        public Parallelogram(double baseLength, double height, double angle)
        {
            if (baseLength <= 0 || height <= 0 || angle <= 0 || angle >= 180)
            {
                throw new ArgumentException("Invalid values for base length, height, or angle.");
            }

            Base = baseLength;
            Height = height;
            AngleBetweenBaseAndAdjacentSide = angle;
            SideLengths[0] = baseLength;
            SideLengths[2] = height;
            SideLengths[1] = Math.Sin(angle * Math.PI / 180) * height; // Adjacent side length
            SideLengths[3] = Math.Cos(angle * Math.PI / 180) * baseLength; // Opposite side length
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return Base * Height;
        }

        private double CalculatePerimeter()
        {
            return 2 * (Base + SideLengths[1]);
        }
    }
}
