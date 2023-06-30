#include "Square.h"

Square::Square()
{
    this->a = 0;
    this->b = 0;
}

Square::Square(int sideA, int sideB) : a(sideA), b(sideB) {}

int Square::getSideA() const
{
    return a;
}

int Square::getSideB() const
{
    return b;
}

void Square::setSideA(int sideA)
{
    a = sideA;
}

void Square::setSideB(int sideB)
{
    b = sideB;
}

string Square::ToString() const
{
    return "Square: " + to_string(a) + ", " + to_string(b);
}