#pragma once
#include <iostream>
#include <string>
using namespace std;

class Hero
{
public:
	Hero(string type, int MP, int CP, int HP);
	virtual void attack();
	virtual void showParams();
protected:
	string getType();
	int getMP();
	int getCP();
	int getHP();
private:
	string _type;
	int _MP, _CP, _HP;
};

