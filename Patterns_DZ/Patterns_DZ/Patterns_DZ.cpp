#include <iostream>
using namespace std;

//product
class Toy {
public:
    virtual void create() = 0;
};

//concrete product
class ToyDuck : public Toy {
public:
    void create() override {
        cout << "Toy duck create!" << endl;
    }
};

//concrete product
class ToyCar : public Toy {
public:
    void create() override {
        cout << "Toy car create!" << endl;
    }
};

//creator
class InjectionMold {
public:
    virtual Toy* injectMold() = 0;
};

//concrete creator
class ToyDuckMold : public InjectionMold {
public:
    Toy* injectMold() override {
        return new ToyDuck();
    }
};

//concrete creator
class ToyCarMold : public InjectionMold {
public:
    Toy* injectMold() override {
        return new ToyCar();
    }
};

int main()
{
    InjectionMold* toyDuckMold = new ToyDuckMold();
    InjectionMold* toyCarMold = new ToyCarMold();
    Toy* toyDuck = toyDuckMold->injectMold();
    Toy* toyCar = toyCarMold->injectMold();

    toyDuck->create();
    toyCar->create();

    return 0;
}