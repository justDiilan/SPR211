#include <iostream>
using namespace std;

class Door {
public:
    virtual void create() = 0;
};

class Wing {
public:
    virtual void create() = 0;
};

class Hood {
public:
    virtual void create() = 0;
};

// Конкретные реализации кузовных деталей для Toyota
class ToyotaDoor : public Door {
public:
    void create() override {
        cout << "Create door Toyota" << endl;
    }
};

class ToyotaWing : public Wing {
public:
    void create() override {
        cout << "Create wing Toyota" << endl;
    }
};

class ToyotaHood : public Hood {
public:
    void create() override {
        cout << "Create hood Toyota" << endl;
    }
};

// Конкретные реализации кузовных деталей для Honda
class HondaDoor : public Door {
public:
    void create() override {
        cout << "Create door Honda" << endl;
    }
};

class HondaWing : public Wing {
public:
    void create() override {
        cout << "Create wing Honda" << endl;
    }
};

class HondaHood : public Hood {
public:
    void create() override {
        cout << "Create hood Honda" << endl;
    }
};

// Абстрактная фабрика
class CarFactory {
public:
    virtual Door* createDoor() = 0;
    virtual Wing* createWing() = 0;
    virtual Hood* createHood() = 0;
};

// Конкретные фабрики для Toyota и Honda
class ToyotaFactory : public CarFactory {
public:
    Door* createDoor() override {
        return new ToyotaDoor();
    }

    Wing* createWing() override {
        return new ToyotaWing();
    }

    Hood* createHood() override {
        return new ToyotaHood();
    }
};

class HondaFactory : public CarFactory {
public:
    Door* createDoor() override {
        return new HondaDoor();
    }

    Wing* createWing() override {
        return new HondaWing();
    }

    Hood* createHood() override {
        return new HondaHood();
    }
};

int main()
{
    // Используем фабрику Toyota для создания деталей
    CarFactory* toyotaFactory = new ToyotaFactory();
    Door* toyotaDoor = toyotaFactory->createDoor();
    Wing* toyotaWing = toyotaFactory->createWing();
    Hood* toyotaHood = toyotaFactory->createHood();

    toyotaDoor->create();
    toyotaWing->create();
    toyotaHood->create();

    // Используем фабрику Honda для создания деталей
    CarFactory* hondaFactory = new HondaFactory();
    Door* hondaDoor = hondaFactory->createDoor();
    Wing* hondaWing = hondaFactory->createWing();
    Hood* hondaHood = hondaFactory->createHood();

    hondaDoor->create();
    hondaWing->create();
    hondaHood->create();

    return 0;
}