#include <iostream>
using namespace std;

class Figure {
public:
    virtual double Square() = 0;
};

class Rectangle : public Figure {
public:
    Rectangle(double a, double b) : _a(a), _b(b) {}

    double Square() override {
        return _a * _b;
    }
private:
    double _a, _b;
};

class Circle : public Figure {
public: 
    Circle(double r) : _r(r) {}

    double Square() override {
        return pi * (_r * _r);
    }
private:
    double _r;
    const double pi = 3.14;
};

class RightTriangle : public Figure {
public:
    RightTriangle(double a, double h) : _a(a), _h(h) {}

    double Square() override {
        return (_a * _h) / 2;
    }
private:
    double _a, _h;
};

class Trapezoid : public Figure {
public:
    Trapezoid(double a, double b, double h) : _a(a), _b(b), _h(h) {}

    double Square() override {
        return ((_a + _b) * _h) / 2;
    }
private:
    double _a, _b, _h;
};

int main()
{
    Rectangle rectangle(3, 5);
    Circle circle(3);
    RightTriangle rightTriangle(4, 3);
    Trapezoid trapezoid(2, 6, 4);

    Figure* figures[] = { &rectangle, &circle, &rightTriangle, &trapezoid };

    for (int i = 0; i < 4; ++i) {
        cout << "Square figure " << i + 1 << ": " << figures[i]->Square() << endl;
    }

    return 0;
}