#include "Scout.h"

void Scout::attack()
{
	cout << this->getType() << " use short melee weapon." << endl;
}

void Scout::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
