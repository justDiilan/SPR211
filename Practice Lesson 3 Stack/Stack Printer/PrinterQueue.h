#pragma once
#include "Stack.h"
#include "PrintRequest.h"
using namespace std;
class PrinterQueue
{
private:
    Stack<PrintRequest> mainStack; // ќсновной стек
    Stack<PrintRequest> auxStack; // ¬спомогательный стек

public:
    void addPrintRequest(const string& user, int priority) {
        PrintRequest request(user, priority);
        // ѕока основной стек не пуст и приоритет верхнего элемента больше или равен новому запросу,
        // перемещаем элементы из основного стека во вспомогательный.
        while (!mainStack.empty() && mainStack.top().priority >= priority) {
            auxStack.push(mainStack.top());
            mainStack.pop();
        }
        // ѕомещаем новый запрос на печать в основной стек.
        mainStack.push(request);
        // ¬озвращаем элементы из вспомогательного стека обратно в основной.
        while (!auxStack.empty()) {
            mainStack.push(auxStack.top());
            auxStack.pop();
        }
    }

    void processPrintRequests() {
        while (!mainStack.empty()) {
            const PrintRequest& request = mainStack.top();
            std::cout << "Printing: User: " << request.user << ", Priority: " << request.priority << std::endl;
            mainStack.pop();
        }
    }

    void printStatistics() {
        cout << "Printing Statistics:" << std::endl;
        Stack<PrintRequest> tempStack; // ¬ременный стек дл€ вывода статистики
        while (!mainStack.empty()) {
            const PrintRequest& stat = mainStack.top();
            cout << "User: " << stat.user << ", Time: " << ctime(&stat.timestamp);
            tempStack.push(stat);
            mainStack.pop();
        }
        // ¬озвращаем элементы из временного стека обратно в основной.
        while (!tempStack.empty()) {
            mainStack.push(tempStack.top());
            tempStack.pop();
        }
    }
};