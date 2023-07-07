#include "IntegerSet.h"

IntegerSet::IntegerSet()
{
	elements = nullptr;
	size = 0;
}

IntegerSet::IntegerSet(int* arr, int arrSize)
{
	size = 0;
	elements = new int[arrSize];
		for (int i = 0; i < arrSize; ++i) {
	        if (!contains(arr[i])) {
	            elements[size++] = arr[i];
	        }
	    }
}

IntegerSet::IntegerSet(const IntegerSet& other)
{
	size = other.size;
	elements = new int[size];
	for (int i = 0; i < size; ++i) {
		elements[i] = other.elements[i];
	}
}

IntegerSet::~IntegerSet()
{
	delete[] elements;
}

bool IntegerSet::contains(int element) const
{
	for (int i = 0; i < size; ++i) {
		if (elements[i] == element) {
			return true;
		}
	}
	return false;
}

IntegerSet& IntegerSet::operator+=(int element)
{
	if (!contains(element)) {
		int* newElements = new int[size + 1];
		for (int i = 0; i < size; ++i) {
			newElements[i] = elements[i];
		}
		newElements[size++] = element;
		delete[] elements;
		elements = newElements;
	}
	return *this;
}

IntegerSet IntegerSet::operator+(int element)
{
	IntegerSet result(*this);
	result += element;
	return result;
}

IntegerSet& IntegerSet::operator-=(int element)
{
	if (contains(element)) {
		int* newElements = new int[size - 1];
		int newIndex = 0;
		for (int i = 0; i < size; ++i) {
			if (elements[i] != element) {
				newElements[newIndex++] = elements[i];
			}
		}
		delete[] elements;
		elements = newElements;
		size--;
	}
	return *this;
}

IntegerSet IntegerSet::operator-(int element)
{
	IntegerSet result(*this);
	result -= element;
	return result;
}

IntegerSet& IntegerSet::operator+=(const IntegerSet& other)
{
	for (int i = 0; i < other.size; ++i) {
		*this += other.elements[i];
	}
	return *this;
}

IntegerSet IntegerSet::operator+(const IntegerSet& other)
{
	IntegerSet result(*this);
	result += other;
	return result;
}

IntegerSet& IntegerSet::operator-=(const IntegerSet& other)
{
	for (int i = 0; i < other.size; ++i) {
		*this -= other.elements[i];
	}
	return *this;
}

IntegerSet IntegerSet::operator-(const IntegerSet& other)
{
	IntegerSet result(*this);
	result -= other;
	return result;
}

IntegerSet& IntegerSet::operator*=(const IntegerSet& other)
{
	for (int i = 0; i < size; ++i) {
		if (!other.contains(elements[i])) {
			*this -= elements[i];
			i--;
		}
	}
	return *this;
}

IntegerSet IntegerSet::operator*(const IntegerSet& other)
{
	IntegerSet result(*this);
	result *= other;
	return result;
}

IntegerSet& IntegerSet::operator=(const IntegerSet& other)
{
	if (this != &other) {
		delete[] elements;
		size = other.size;
		elements = new int[size];
		for (int i = 0; i < size; ++i) {
			elements[i] = other.elements[i];
		}
	}
	return *this;
}

bool IntegerSet::operator==(const IntegerSet& other)
{
	if (size != other.size) {
		return false;
	}
	for (int i = 0; i < size; ++i) {
		if (!other.contains(elements[i])) {
			return false;
		}
	}
	return true;
}

ostream& operator<<(ostream& os, IntegerSet& set)
{
	os << "{";
	for (int i = 0; i < set.size; ++i) {
		os << set.elements[i];
		if (i != set.size - 1) {
			os << ", ";
		}
	}
	os << "}";
	return os;
}

istream& operator>>(istream& is, IntegerSet& set)
{
	int element;
	while (is >> element) {
		set += element;
	}
	return is;
}