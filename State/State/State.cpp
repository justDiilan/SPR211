#include <iostream>
using namespace std;

// Абстрактный класс для состояний торгового автомата
class VendingMachineState {
public:
    virtual void insertCurrency(int amount) = 0;
    virtual void selectProduct(int productId) = 0;
    virtual void dispenseProduct() = 0;
};

// Конкретное состояние: состояние депозита
class VendingDepositeState : public VendingMachineState {
private:
    int currentDeposit;
public:
    VendingDepositeState() : currentDeposit(0) {}

    void insertCurrency(int amount) override {
        currentDeposit += amount;
        cout << "Submitted " << amount << " currencies. Total amount: " << currentDeposit << endl;
    }

    void selectProduct(int productId) override {
        cout << "Product ID selected " << productId << endl;
    }

    void dispenseProduct() override {
        cout << "Please select a product." << endl;
    }
};

// Конкретное состояние: состояние запасов
class VendingStockState : public VendingMachineState {
public:
    void insertCurrency(int amount) override {
        cout << "You must first select a product." << endl;
    }

    void selectProduct(int productId) override {
        cout << "Product ID selected " << productId << endl;
    }

    void dispenseProduct() override {
        cout << "The product has been delivered." << endl;
    }
};

int main() {
    VendingMachineState* currentState = new VendingDepositeState();

    currentState->insertCurrency(10);
    currentState->selectProduct(1);
    currentState->dispenseProduct();

    // Можно изменить состояние
    delete currentState;
    currentState = new VendingStockState();

    currentState->insertCurrency(5);
    currentState->selectProduct(2);
    currentState->dispenseProduct();

    delete currentState;

    return 0;
}