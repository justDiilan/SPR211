#pragma once
#include "Scout.h"

class Assassin : public Scout
{
public:
	Assassin(string type, int MP, int CP, int HP) : Scout(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};
