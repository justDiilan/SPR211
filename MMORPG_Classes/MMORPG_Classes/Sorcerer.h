#pragma once
#include "Mage.h"

class Sorcerer : public Mage
{
public:
	Sorcerer(string type, int MP, int CP, int HP) : Mage(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};

