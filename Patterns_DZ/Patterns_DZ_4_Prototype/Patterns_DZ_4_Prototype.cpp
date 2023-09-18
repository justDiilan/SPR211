#include <iostream>
#include <string>
using namespace std;

class Cell {
public:
    virtual Cell* split() = 0;
    virtual void print() = 0;
};

class SingleCellOrganism : public Cell {
private:
    string genotype;

public:
    SingleCellOrganism(const string& genotype) : genotype(genotype) {}

    Cell* split() override {
        return new SingleCellOrganism(genotype);
    }

    void print() override {
        cout << "Cell with genotype: " << genotype << endl;
    }
};

int main()
{
    Cell* cell = new SingleCellOrganism("Cell genotype A");

    Cell* clonedCell = cell->split();

    cell->print();
    clonedCell->print();

    return 0;
}