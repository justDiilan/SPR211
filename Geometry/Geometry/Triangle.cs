using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle : GeometricFigure, SimplePolygon
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; } = 3;
        public double[] SideLengths { get; set; } = new double[3];

        //public double Area
        //{
        //    get
        //    {
        //        return 0.5 * Base * Height;
        //    }
        //}

        //public double Perimeter
        //{
        //    get
        //    {
        //        return SideLengths[0] + SideLengths[1] + SideLengths[2];
        //    }
        //}

        public Triangle(double baseLength, double height, double side1, double side2, double side3)
        {
            if (baseLength <= 0 || height <= 0 || side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Invalid values for side lengths or height.");
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("Triangle with these side lengths does not exist.");
            }

            Base = baseLength;
            Height = height;
            SideLengths[0] = side1;
            SideLengths[1] = side2;
            SideLengths[2] = side3;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        private double CalculatePerimeter()
        {
            return SideLengths[0] + SideLengths[1] + SideLengths[2];
        }
    }
}
