using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal interface SimplePolygon
    {
        double Height { get; set; }
        double Base { get; set; }
        double AngleBetweenBaseAndAdjacentSide { get; set; }
        int NumberOfSides { get; set; }
        double[] SideLengths { get; set; }
        double Area { get; }
        double Perimeter { get; }
    }
}
