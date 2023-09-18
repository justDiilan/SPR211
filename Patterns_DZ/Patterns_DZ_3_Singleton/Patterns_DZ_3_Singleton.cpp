#include <iostream>
using namespace std;

class Government {
private:
    Government() {}

    static Government* instance;

public:
    static Government* getInstance() {
        if (instance == nullptr) {
            instance = new Government();
        }
        return instance;
    }

    void election() {
        cout << "Election is held, and a new President is elected!" << endl;
    }
};

Government* Government::instance = nullptr;

int main() {
    Government* presidentOffice = Government::getInstance();

    presidentOffice->election();

    return 0;
}