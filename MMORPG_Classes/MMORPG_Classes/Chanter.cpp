#include "Chanter.h"

void Chanter::attack()
{
	cout << this->getType() << " use singing for healing." << endl;
}

void Chanter::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
