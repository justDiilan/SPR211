#include "Triangle.h"

Triangle::Triangle()
{
    a = 0;
    b = 0;
    c = 0;
}

Triangle::Triangle(int sideA, int sideB, int sideC) : a(sideA), b(sideB), c(sideC) {}

int Triangle::getSideA() const
{
    return a;
}

int Triangle::getSideB() const
{
    return b;
}

int Triangle::getSideC() const
{
    return c;
}

void Triangle::setSideA(int sideA)
{
    a = sideA;
}

void Triangle::setSideB(int sideB)
{
    b = sideB;
}

void Triangle::setSideC(int sideC)
{
    c = sideC;
}

string Triangle::ToString() const
{
    return "Triangle: " + to_string(a) + ", " + to_string(b) + ", " + to_string(c);
}