#pragma once
#include <iostream>
using namespace std;

class IntegerSet
{
public:
	IntegerSet();
	IntegerSet(int* arr, int arrSize);
	IntegerSet(const IntegerSet& other);
	~IntegerSet();
	bool contains(int element) const;
	IntegerSet& operator+=(int element);
	IntegerSet operator+(int element);
	IntegerSet& operator-=(int element);
	IntegerSet operator-(int element);
	IntegerSet& operator+=(const IntegerSet& other);
	IntegerSet operator+(const IntegerSet& other);
	IntegerSet& operator-=(const IntegerSet& other);
	IntegerSet operator-(const IntegerSet& other);
	IntegerSet& operator*=(const IntegerSet& other);
	IntegerSet operator*(const IntegerSet& other);
	IntegerSet& operator=(const IntegerSet& other);
	bool operator==(const IntegerSet& other);
	friend ostream& operator<<(ostream& os, IntegerSet& set);
	friend istream& operator>>(istream& is, IntegerSet& set);
private:
	int* elements;
	int size;
};

