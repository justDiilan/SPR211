#pragma once
#include <iostream>
#include <ostream>

using namespace std;

template<class T>
class Stack
{
public:
	Stack(int capacity);
	Stack(const Stack& other);
	Stack(Stack&& other);
	~Stack();
	Stack<T>& operator= (const Stack& other);
	Stack<T>& operator= (Stack&& other);
	friend ostream& operator<<<T> (ostream& out, const Stack& stack);
	bool empty();
	void push(T item);
	void pop();
	T& top();
	int getSize();
	int getCapacity();
	void setCapacity(int capacity);
private:
	T* _data;
	int _size;
	int _capacity;
	int _index;
};