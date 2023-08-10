#include <iostream>
#include "Stack.h"
#include "Stack.cpp"
#include "Node.cpp"
using namespace std;

int main()
{
    Stack<int> myStack;

    myStack.push(10);
    myStack.push(20);
    myStack.push(30);

    cout << "Stack contents: ";
    myStack.print();

    cout << "Top element: " << myStack.top() << endl;

    myStack.pop();

    cout << "Top element after pop: " << myStack.top() << endl;

    return 0;
}