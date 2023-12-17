using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Ellipse : GeometricFigure
    {
        public double SemiMajorAxis { get; set; }
        public double SemiMinorAxis { get; set; }

        public Ellipse(double semiMajorAxis, double semiMinorAxis)
        {
            if (semiMajorAxis <= 0 || semiMinorAxis <= 0)
            {
                throw new ArgumentException("Invalid values for semi-major or semi-minor axis.");
            }

            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        private double CalculateArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }

        private double CalculatePerimeter()
        {
            double h = Math.Pow((SemiMajorAxis - SemiMinorAxis) / (SemiMajorAxis + SemiMinorAxis), 2);
            return Math.PI * (SemiMajorAxis + SemiMinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }
    }
}
