#include "Templar.h"

void Templar::attack()
{
	cout << this->getType() << " use two-handed sword." << endl;
}

void Templar::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
