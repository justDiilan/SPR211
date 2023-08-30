#include "Assassin.h"

void Assassin::attack()
{
	cout << this->getType() << " use hidden blades." << endl;
}

void Assassin::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
