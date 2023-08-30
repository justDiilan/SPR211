#include "Cleric.h"

void Cleric::attack()
{
	cout << this->getType() << " use crucifixion." << endl;
}

void Cleric::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
