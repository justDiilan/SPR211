#include <iostream>
using namespace std;

class Calculate {
	virtual void EquationRoots() = 0;
};

class CalculateLinear : public Calculate {
public:
	CalculateLinear(double a, double b) : _a(a), _b(b) {}

    void EquationRoots() override {
        cout << "The equation: " << _a << "x = " << _b << endl;
        if (_a == 0) {
            if (_b == 0) {
                cout << "Infinite number of roots." << endl;
            }
            else {
                cout << "No roots." << endl;
            }
        }
        else {
            double root = _b / _a;
            cout << "One root: x = " << root << endl;
        }
    }
protected:
	double _a, _b;
};

class CalculateQuadratic : public Calculate {
public:
    CalculateQuadratic(double a, double b, double c) : _a(a), _b(b), _c(c) {}

    void EquationRoots() override {
        cout << "The equation: " << _a << "x^2 " << _b << "x + " << _c << endl;
        if (_a == 0) {
            cout << "The coefficient \"a\" cannot be equal to zero." << endl;
        }
        else {
            _d = (_b * _b) - (4 * _a * _c);
            if (_d > 0) {
                x1 = (-_b + sqrt(_d)) / (2 * _a);
                x2 = (-_b - sqrt(_d)) / (2 * _a);
                cout << "x1 = " << x1 << "; x2 = " << x2 << endl;
            }
            else if (_d = 0) {
                x1 = -_b / (2 * _a);
                cout << "x = " << x1 << endl;
            }
            else {
                cout << "The equation has no real roots" << endl;
            }
        }
    }
protected:
    double _a, _b, _c, _d, x1, x2;
};

void Show(CalculateLinear& calculateLinear, CalculateQuadratic& calculateQuadratic) {
    calculateLinear.EquationRoots();
    calculateQuadratic.EquationRoots();
}

int main()
{
    CalculateLinear calculateLinear(2, 3);
    CalculateQuadratic calculateQuadratic(1, -3, 2);

    Show(calculateLinear, calculateQuadratic);

	return 0;
}