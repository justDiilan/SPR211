#include "CalcFigures.h"
#include <iostream>

int main()
{
    Figures figures;
    figures.setSizeS(2);
    figures.setSizeT(3);

    Square* squares = figures.getSquares();
    squares[0] = Square(4, 4);
    squares[1] = Square(5, 5);

    Triangle* triangles = figures.getTriangles();
    triangles[0] = Triangle(3, 4, 5);
    triangles[1] = Triangle(6, 8, 10);
    triangles[2] = Triangle(5, 12, 13);

    CalcFigures::ShowArea(figures);
    CalcFigures::ShowPerimeter(figures);
    CalcFigures::ShowFiguresCMD(figures);

    return 0;
}