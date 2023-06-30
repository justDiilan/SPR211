#include "Figures.h"

Figures::Figures() : _sizeS(0), _sizeT(0), _s(nullptr), _t(nullptr) {}

Figures::Figures(const Figures& other)
{
    _sizeS = other._sizeS;
    _sizeT = other._sizeT;

    _s = new Square[_sizeS];
    _t = new Triangle[_sizeT];

    for (int i = 0; i < _sizeS; i++)
    {
        _s[i] = other._s[i];
    }

    for (int i = 0; i < _sizeT; i++)
    {
        _t[i] = other._t[i];
    }
}

Figures::~Figures()
{
    delete[] _s;
    delete[] _t;
}

int Figures::getSizeS() const
{
    return _sizeS;
}

int Figures::getSizeT() const
{
    return _sizeT;
}

void Figures::setSizeS(int sizeS)
{
    _sizeS = sizeS;
    delete[] _s;
    _s = new Square[_sizeS];
}

void Figures::setSizeT(int sizeT)
{
    _sizeT = sizeT;
    delete[] _t;
    _t = new Triangle[_sizeT];
}

string Figures::ToString() const
{
    string result = "Figures:\n";
    for (int i = 0; i < _sizeS; i++)
    {
        result += _s[i].ToString() + "\n";
    }
    for (int i = 0; i < _sizeT; i++)
    {
        result += _t[i].ToString() + "\n";
    }
    return result;
}

Square* Figures::getSquares() const
{
    return _s;
}

Triangle* Figures::getTriangles() const
{
    return _t;
}
