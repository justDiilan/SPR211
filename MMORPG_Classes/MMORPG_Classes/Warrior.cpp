#include "Warrior.h"

void Warrior::attack()
{
	cout << this->getType() << " use long melee weapon." << endl;
}

void Warrior::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
