#include "Spiritmaster.h"

void Spiritmaster::attack()
{
	cout << this->getType() << " use totems." << endl;
}

void Spiritmaster::showParams()
{
	cout << "Perks of " << this->getType() << ": MP-> " << getMP() << "; CP-> " << getCP() << "; HP-> " << getHP() << endl;
}
