#pragma once
#include "Stack.h"
#include "PrintRequest.h"
using namespace std;
class PrinterQueue
{
private:
    Stack<PrintRequest> mainStack; // �������� ����
    Stack<PrintRequest> auxStack; // ��������������� ����

public:
    void addPrintRequest(const string& user, int priority) {
        PrintRequest request(user, priority);
        // ���� �������� ���� �� ���� � ��������� �������� �������� ������ ��� ����� ������ �������,
        // ���������� �������� �� ��������� ����� �� ���������������.
        while (!mainStack.empty() && mainStack.top().priority >= priority) {
            auxStack.push(mainStack.top());
            mainStack.pop();
        }
        // �������� ����� ������ �� ������ � �������� ����.
        mainStack.push(request);
        // ���������� �������� �� ���������������� ����� ������� � ��������.
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
        Stack<PrintRequest> tempStack; // ��������� ���� ��� ������ ����������
        while (!mainStack.empty()) {
            const PrintRequest& stat = mainStack.top();
            cout << "User: " << stat.user << ", Time: " << ctime(&stat.timestamp);
            tempStack.push(stat);
            mainStack.pop();
        }
        // ���������� �������� �� ���������� ����� ������� � ��������.
        while (!tempStack.empty()) {
            mainStack.push(tempStack.top());
            tempStack.pop();
        }
    }
};