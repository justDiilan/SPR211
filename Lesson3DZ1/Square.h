#pragma once
#include <string>
using namespace std;

class Square
{
public:
    Square();
    Square(int sideA, int sideB);

    int getSideA() const;
    int getSideB() const;

    void setSideA(int sideA);
    void setSideB(int sideB);

    string ToString() const;

private:
    int a, b;
};

