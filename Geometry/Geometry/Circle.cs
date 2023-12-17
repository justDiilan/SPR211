using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Circle : GeometricFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Invalid value for radius.");
            }

            Radius = radius;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        private double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
