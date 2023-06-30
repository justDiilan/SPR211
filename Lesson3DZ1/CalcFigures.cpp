#include "CalcFigures.h"
#include <iostream>

void CalcFigures::ShowArea(const Figures& f)
{
    const Square* squares = f.getSquares();
    const Triangle* triangles = f.getTriangles();

    cout << "Areas:\n";

    for (int i = 0; i < f.getSizeS(); i++)
    {
        int area = squares[i].getSideA() * squares[i].getSideB();
        cout << "Square " << i + 1 << ": " << area << "\n";
    }

    for (int i = 0; i < f.getSizeT(); i++)
    {
        const Triangle& triangle = triangles[i];
        double p = (triangle.getSideA() + triangle.getSideB() + triangle.getSideC()) / 2.0;
        double area = std::sqrt(p * (p - triangle.getSideA()) * (p - triangle.getSideB()) * (p - triangle.getSideC()));
        cout << "Triangle " << i + 1 << ": " << area << "\n";
    }
}

void CalcFigures::ShowPerimeter(const Figures& f)
{
    const Square* squares = f.getSquares();
    const Triangle* triangles = f.getTriangles();

    cout << "Perimeters:\n";

    for (int i = 0; i < f.getSizeS(); i++)
    {
        int perimeter = 2 * (squares[i].getSideA() + squares[i].getSideB());
        cout << "Square " << i + 1 << ": " << perimeter << "\n";
    }

    for (int i = 0; i < f.getSizeT(); i++)
    {
        int perimeter = triangles[i].getSideA() + triangles[i].getSideB() + triangles[i].getSideC();
        cout << "Triangle " << i + 1 << ": " << perimeter << "\n";
    }
}

void CalcFigures::ShowFiguresCMD(const Figures& f)
{
    cout << f.ToString();
}
