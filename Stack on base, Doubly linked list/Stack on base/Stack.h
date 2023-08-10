#pragma once
#include "Node.h"
#include <iostream>
using namespace std;

template<typename T>
class Stack
{
public:
	Stack();
	~Stack();
	bool empty() const;
	void push(const T& value);
	void pop();
	T top() const;
	void print() const;
private:
	Node<T>* topNode;
};