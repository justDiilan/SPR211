#pragma once
#include "Warrior.h"

class Gladiator : public Warrior
{
public:
	Gladiator(string type, int MP, int CP, int HP) : Warrior(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};

