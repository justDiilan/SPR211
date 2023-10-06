#include <iostream>
#include <string>
using namespace std;

// Абстрактный класс для работы с платежами
class Payment {
public:
    virtual void amount() = 0;
};

// Конкретный класс для выполнения платежей
class FundsPaidFromAccount : public Payment {
public:
    void amount() override {
        cout << "Payment completed" << endl;
    }
};

// Заместитель (прокси) для работы с чеками
class CheckProxy : public Payment {
private:
    Payment* realSubject;

public:
    CheckProxy() : realSubject(nullptr) {}

    void amount() override {
        if (realSubject == nullptr) {
            realSubject = new FundsPaidFromAccount();
        }
        // Вызываем метод amount() на реальном объекте или классе
        realSubject->amount();
    }

    ~CheckProxy() {
        if (realSubject != nullptr) {
            delete realSubject;
        }
    }
};

int main() {
    Payment* payment = new CheckProxy();

    // Вызываем метод amount() через прокси
    payment->amount();

    delete payment;

    return 0;
}