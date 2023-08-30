#include "Priest.h"

void Priest::attack()
{
	cout << this->getType() << " use prayer." << endl;
}

void Priest::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
