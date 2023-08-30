#pragma once
#include "Mage.h"

class Spiritmaster : public Mage
{
public:
	Spiritmaster(string type, int MP, int CP, int HP) : Mage(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};

