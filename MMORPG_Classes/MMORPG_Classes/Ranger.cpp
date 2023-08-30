#include "Ranger.h"

void Ranger::attack()
{
	cout << this->getType() << " use twin short blades." << endl;
}

void Ranger::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
