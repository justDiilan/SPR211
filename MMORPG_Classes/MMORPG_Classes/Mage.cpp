#include "Mage.h"

void Mage::attack()
{
	cout << this->getType() << " use ranged weapon." << endl;
}

void Mage::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
