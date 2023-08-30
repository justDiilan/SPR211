#include "Gladiator.h"

void Gladiator::attack()
{
	cout << this->getType() << " use two-handed hummer." << endl;
}

void Gladiator::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
