using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class CompositeFigure
    {
        private readonly GeometricFigure[] _geometricFigures;

        public CompositeFigure(GeometricFigure[] geometricFigures)
        {
            _geometricFigures = geometricFigures;
        }

        public double FindArea()
        {
            double area = 0;

            foreach (var geometricFigure in _geometricFigures)
            {
                area += geometricFigure.Area;
            }

            return area;
        }

        public double FindPerimeter()
        {
            double perimeter = 0;

            foreach (var geometricFigure in _geometricFigures)
            {
                perimeter += geometricFigure.Perimeter;
            }

            return perimeter;
        }
    }
}
