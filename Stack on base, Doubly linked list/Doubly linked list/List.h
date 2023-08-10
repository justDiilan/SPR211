#pragma once
#include <iostream>
using namespace std;

template<class T1>
class Node;

template<class T>
class List
{
public:
	List();
	~List();
	void add(T data);
	void clear();
	int getSize();
	Node<T>& getHead();
	Node<T>& getTail();
	T& operator[] (int index);
	void insert(T data, int index);
	void replace(T data, int index);
	void del(int index);
private:
	Node<T>* head;
	Node<T>* tail;
	int size;
};

template<class T1>
class Node {
public:
	Node<T1>* next;
	Node<T1>* prev;
	T1 data;
};