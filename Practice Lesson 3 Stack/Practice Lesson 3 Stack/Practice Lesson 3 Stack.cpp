#include <iostream>
#include <string>
#include "Stack.h"
#include "Stack.cpp"
using namespace std;

bool isMatchingPair(char opening, char closing) {
	return (opening == '(' && closing == ')') ||
		(opening == '{' && closing == '}') ||
		(opening == '[' && closing == ']');
}

void checkBrackets(const string& expression) {
    Stack<char> stack(20);

    for (size_t i = 0; i < expression.length(); ++i) {
        char currentChar = expression[i];

        if (currentChar == '(' || currentChar == '{' || currentChar == '[') {
            stack.push(currentChar);
        }
        else if (currentChar == ')' || currentChar == '}' || currentChar == ']') {
            if (stack.empty() || !isMatchingPair(stack.top(), currentChar)) {
                cout << "Error in placing brackets at a position " << (i + 1) << endl;
                return;
            }
            else {
                stack.pop();
            }
        }
    }
    if (stack.empty()) {
        cout << "The parentheses are placed correctly." << endl;
    }
    else {
        cout << "Error in placing brackets at a position " << (expression.length() - stack.top()) << endl;
    }
}

int main()
{
    string expression;
    cout << "Enter a string with brackets: ";
    getline(cin, expression);

    checkBrackets(expression);

    return 0;

	/*Stack<int> stack(5);
	stack.push(5);
	stack.push(3);
	stack.push(25);
	stack.pop();

	stack.setCapacity(7);
		
	cout << stack << endl;

	stack.setCapacity(6);
	cout << stack << endl;*/

	return 0;
}