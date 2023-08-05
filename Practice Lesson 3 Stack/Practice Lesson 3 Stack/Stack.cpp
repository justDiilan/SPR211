#include "Stack.h"

template<class T>
inline Stack<T>::Stack(int capacity)
{
	_capacity = capacity;
	_size = 0;
	_data = new T[_capacity] { 0 };
	_index = _capacity;
	if (_capacity <= 0)
	{
		_capacity = 0;
		_data = nullptr;
		_index = 0;
	}
	cout << "constructor default:\t" << this << endl;
}

template<class T>
Stack<T>::Stack(const Stack& other)
{
	if (this == &other) return *this;
	_index = other._index;
	_capacity = other._capacity;
	_size = other._size;
	_data = new T[_size];
	for (size_t i = 0; i < _size; i++)
	{
		_data[i] = other._data[i];
	}
	cout << "constructor copy:\t" << this << endl;
}

template<class T>
Stack<T>::Stack(Stack&& other)
{
	_data = nullptr;
	_size = 0;
	_index = other._index;
	_capacity = other._capacity;
	_data = other._data;
	_size = other._size;
	other._data = nullptr;
	other._size = 0;
	other._capacity = 0;
	cout << "constructor moving:\t" << this << endl;
}

template<class T>
Stack<T>::~Stack()
{
	if (_data != nullptr)
		delete[] _data;
	cout << "destructor:\t" << this << endl;
}

template<class T>
Stack<T>& Stack<T>::operator=(const Stack& other)
{
	if (this == &other) return *this;
	_index = other._index;
	_capacity = other._capacity;
	_size = other._size;
	_data = new T[_size];
	for (size_t i = 0; i < _size; i++)
	{
		_data[i] = other._data[i];
	}
	cout << "operator copy:\t" << this << endl;
	return *this;
}

template<class T>
Stack<T>& Stack<T>::operator=(Stack&& other)
{
	_index = other._index;
	_capacity = other._capacity;
	_data = other._data;
	_size = other._size;
	other._data = nullptr;
	other._size = 0;
	other._capacity = 0;
	other._index = 0;
	cout << "operator moving:\t" << this << endl;
}

template<class T>
bool Stack<T>::empty()
{
	if (_size == 0) return true;
	return false;
}

template<class T>
void Stack<T>::push(T item)
{
	if (_capacity <= _size)
	{
		cout << "Stack overflow:\t" << item << endl;
		return;
	}
	_data[--_index] = item;
	_size++;
}

template<class T>
void Stack<T>::pop()
{
	if (_size != 0)
	{
		_data[_index++] = 0;
		_size--;
	}
}

template<class T>
T& Stack<T>::top()
{
	return _data[_index];
}

template<class T>
int Stack<T>::getSize()
{
	return _size;
}

template<class T>
int Stack<T>::getCapacity()
{
	return _capacity;
}

template<class T>
void Stack<T>::setCapacity(int capacity)
{
	if (_capacity > 0)
	{
		if (!empty() && _capacity < capacity)
		{
			T* temp = new T[_capacity];
			int tempCapacity = _capacity;
			for (size_t i = 0; i < _capacity; i++)
			{
				temp[i] = _data[i];
			}
			delete[] _data;
			_capacity = capacity;
			_data = new T[_capacity];
			int it = 0;
			for (size_t i = _capacity - tempCapacity; i < _capacity; i++)
			{
				_data[i] = temp[it++];
			}
			delete[] temp;
		}
		if (_capacity > capacity && capacity > _size)
		{
			T* temp = new T[capacity];
			int it = 0;
			for (int i = _capacity - _size; i < _capacity; i++)
			{
				temp[it--] = _data[i];
			}
			_capacity = capacity;
			delete[] _data;
			_data = new T[_capacity]{0};
			for (size_t i = 0; i < _capacity; i++)
			{
				_data[i] = temp[i];
			}
			delete[] temp;
		}
	}
}

template<class T>
ostream& operator<< (ostream& out, const Stack<T>& stack)
{
	for (size_t i = stack._capacity - 1; i >= stack._index; i--)
	{
		out << stack._data[i] << "\n";
	}
	return out;
}