using System.Drawing;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle(3, 4, 5, 5, 6);
                Square square = new Square(4);
                Rhombus rhombus = new Rhombus(4, 60);
                Rectangle rectangle = new Rectangle(3, 5);
                Parallelogram parallelogram = new Parallelogram(4, 5, 30);
                Trapezoid trapezoid = new Trapezoid(3, 5, 4, 4);
                Circle circle = new Circle(5);
                Ellipse ellipse = new Ellipse(6, 4);

                Console.WriteLine($"Triangle perimetr: {triangle.Perimeter}");
                Console.WriteLine($"Triangle area: {triangle.Area}");

                Console.WriteLine($"Square perimetr: {square.Perimeter}");
                Console.WriteLine($"Square area: {square.Area}");

                Console.WriteLine($"Rhombus perimetr: {rhombus.Perimeter}");
                Console.WriteLine($"Rhombus area: {rhombus.Area}");

                Console.WriteLine($"Rectangle perimetr: {rectangle.Perimeter}");
                Console.WriteLine($"Rectangle area: {rectangle.Area}");

                Console.WriteLine($"Parallelogram perimetr: {parallelogram.Perimeter}");
                Console.WriteLine($"Parallelogram area: {parallelogram.Area}");

                Console.WriteLine($"Trapezoid perimetr: {trapezoid.Perimeter}");
                Console.WriteLine($"Trapezoid area: {trapezoid.Area}");

                Console.WriteLine($"Circle perimetr: {circle.Perimeter}");
                Console.WriteLine($"Circle area: {circle.Area}");

                Console.WriteLine($"Ellipse perimetr: {ellipse.Perimeter}");
                Console.WriteLine($"Ellipse area: {ellipse.Area}");

                GeometricFigure[] geometricFigures = { triangle, square, rhombus, rectangle };
                CompositeFigure compositeFigure = new CompositeFigure(geometricFigures);

                double compositeFigureArea = compositeFigure.FindArea();
                double compositeFigurePerimeter = compositeFigure.FindPerimeter();
                Console.WriteLine($"Composite figure area: {compositeFigureArea}");
                Console.WriteLine($"Composite figure perimeter: {compositeFigurePerimeter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}