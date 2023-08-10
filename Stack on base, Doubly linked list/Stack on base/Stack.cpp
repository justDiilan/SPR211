#include "Stack.h"

template<typename T>
Stack<T>::Stack()
{
	topNode = nullptr;
}

template<typename T>
Stack<T>::~Stack()
{
	while (!empty()) {
		pop();
	}
}

template<typename T>
bool Stack<T>::empty() const
{
	return topNode == nullptr;
}

template<typename T>
void Stack<T>::push(const T& value)
{
	Node<T>* newNode = new Node<T>(value);
	newNode->next = topNode;
	topNode = newNode;
}

template<typename T>
void Stack<T>::pop()
{
	if (empty()) 
	{
		return;
	}
	Node<T>* temp = topNode;
	topNode = topNode->next;
	delete temp;
}

template<typename T>
T Stack<T>::top() const
{
	if (empty())
	{
		return T();
	}
	return topNode->data;
}

template<typename T>
void Stack<T>::print() const
{
	Node<T>* current = topNode;
	while (current != nullptr) {
		cout << current->data << " ";
		current = current->next;
	}
	cout << endl;
}
