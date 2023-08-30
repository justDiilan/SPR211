#pragma once
#include "Hero.h"

class Priest : public Hero
{
public:
	Priest(string type, int MP, int CP, int HP) : Hero(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};

