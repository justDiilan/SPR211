#pragma once
#include "Triangle.h"
#include "Square.h"

class Figures
{
public:
    Figures();
    Figures(const Figures& other);
    ~Figures();

    int getSizeS() const;
    int getSizeT() const;

    void setSizeS(int sizeS);
    void setSizeT(int sizeT);

    string ToString() const;

    Square* getSquares() const;
    Triangle* getTriangles() const;

private:
    int _sizeS;
    int _sizeT;
    Square* _s;
    Triangle* _t;
};

