#include "List.h"

template<class T>
List<T>::List()
{
	head = nullptr;
	tail = nullptr;
	size = 0;
	cout << "Constructor default:\t" << endl;
}

template<class T>
List<T>::~List()
{
	cout << "Destructor:\t" << this << endl;
	clear();
}

template<class T>
void List<T>::add(T data)
{
	++size;
	//-----------------------------
	// Новый узел списка
	//-----------------------------
	Node<T>* newNode = new Node<T>;
	newNode->next = nullptr;
	newNode->prev = nullptr;
	newNode->data = data;
	//-----------------------------
	if (head == nullptr)
	{
		head = tail = newNode;
		return;
	}
	newNode->prev = tail;
	tail->next = newNode;
	tail = newNode;
}

template<class T>
void List<T>::clear()
{
	Node<T>* temp = nullptr;
	while (head != nullptr)
	{
		temp = head;
		head = head->next;
		delete temp;
		size--;
	}
	tail = nullptr;
}

template<class T>
int List<T>::getSize()
{
	return size;
}

template<class T>
Node<T>& List<T>::getHead()
{
	return *(head);
}

template<class T>
Node<T>& List<T>::getTail()
{
	return *(tail);
}

template<class T>
T& List<T>::operator[](int index)
{
	if (index < 0 || index > size) throw bad_alloc();
	Node<T>* temp = head;
	while (index-- != 0)
	{
		temp = temp->next;
	}
	return temp->data;
}

template<class T>
void List<T>::insert(T data, int index)
{
	if (index < 0 || index > size) throw bad_alloc();

	Node<T>* newNode = new Node<T>;
	newNode->data = data;

	Node<T>* previous = head;
	Node<T>* next = head;

	while (index-- != 0)
	{
		previous = next;
		next = next->next;
	}
	newNode->prev = previous;
	previous->next = newNode;
	newNode->next = next;
	next->prev = newNode;
	size++;
}

template<class T>
void List<T>::replace(T data, int index)
{
	if (index < 0 || index > size) throw bad_alloc();
	Node<T>* target = head;
	while (index-- != 0)
	{
		target = target->next;
	}
	target->data = data;
}

template<class T>
void List<T>::del(int index)
{
	if (index < 0 || index > size) throw bad_alloc();
	if (size == 1)
	{
		clear();
		return;
	}

	Node<T>* target = head;
	Node<T>* temp = head;

	while (index-- != 0)
	{
		target = target->next;
	}

	if (target == head)
	{
		temp = target->next;
		temp->prev = nullptr;
		delete target;
		return;
	}
	else if (target == tail)
	{
		temp = temp->prev;
		temp->next = nullptr;
		tail = temp;
		delete target;
		return;
	}
	else
	{
		temp = target->prev;
		temp->next = target->next;
		target->next->prev = temp;
		delete target;
	}

	size--;
}