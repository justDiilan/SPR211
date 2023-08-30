#include "Hero.h"

Hero::Hero(string type, int MP, int CP, int HP)
{
	_type = type;
	_MP = MP;
	_CP = CP;
	_HP = HP;
}

void Hero::attack()
{
	cout << this->getType() << " use weapon." << endl;
}

void Hero::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << _MP << "; CP-> " << _CP << "; HP-> " << _HP << endl;
}

string Hero::getType()
{
	return _type;
}

int Hero::getMP()
{
	return _MP;
}

int Hero::getCP()
{
	return _CP;
}

int Hero::getHP()
{
	return _HP;
}
