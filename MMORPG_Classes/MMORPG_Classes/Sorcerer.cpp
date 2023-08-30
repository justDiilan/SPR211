#include "Sorcerer.h"

void Sorcerer::attack()
{
	cout << this->getType() << " use staff." << endl;
}

void Sorcerer::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
