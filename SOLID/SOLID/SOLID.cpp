#include <iostream>
using namespace std;

class ICardReader {
public:
    virtual bool readCard() = 0;
};

class ICashDispenser {
public:
    virtual void dispenseCash(int amount) = 0;
};

class ITransactionProcessor {
public:
    virtual bool processTransaction(int amount) = 0;
};

class CardReader : public ICardReader {
public:
    bool readCard() override {
        std::cout << "Reading card..." << std::endl;
        return true; // Успешное чтение карты
    }
};

class CashDispenser : public ICashDispenser {
public:
    void dispenseCash(int amount) override {
        cout << "Dispensing $" << amount << endl;
    }
};

class TransactionProcessor : public ITransactionProcessor {
public:
    bool processTransaction(int amount) override {
        cout << "Processing transaction: $" << amount << endl;
        return true; // Успешная транзакция
    }
};

class ATM {
public:
    ATM(ICardReader& cardReader, ICashDispenser& cashDispenser, ITransactionProcessor& transactionProcessor)
        : cardReader(cardReader), cashDispenser(cashDispenser), transactionProcessor(transactionProcessor) {}

    void performTransaction(int amount) {
        if (cardReader.readCard()) {
            // Чтение карты прошло успешно
            if (transactionProcessor.processTransaction(amount)) {
                cashDispenser.dispenseCash(amount);
            }
        }
    }

private:
    ICardReader& cardReader;
    ICashDispenser& cashDispenser;
    ITransactionProcessor& transactionProcessor;
};

int main() {
    CardReader cardReader;
    CashDispenser cashDispenser;
    TransactionProcessor transactionProcessor;

    ATM atm(cardReader, cashDispenser, transactionProcessor);

    int amount;
    cout << "Enter the amount you want to withdraw: ";
    cin >> amount;

    atm.performTransaction(amount);

    return 0;
}