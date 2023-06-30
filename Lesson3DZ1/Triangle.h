#pragma once
#include <string>
using namespace std;

class Triangle
{
public:
    Triangle();
    Triangle(int sideA, int sideB, int sideC);

    int getSideA() const;
    int getSideB() const;
    int getSideC() const;

    void setSideA(int sideA);
    void setSideB(int sideB);
    void setSideC(int sideC);

    string ToString() const;

private:
    int a, b, c;
};

