#pragma once
#include "Warrior.h"

class Templar : public Warrior
{
public:
	Templar(string type, int MP, int CP, int HP) : Warrior(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};

