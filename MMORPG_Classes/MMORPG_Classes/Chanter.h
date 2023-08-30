#pragma once
#include "Priest.h"

class Chanter : public Priest
{
public:
	Chanter(string type, int MP, int CP, int HP) : Priest(type, MP, CP, HP) {}
	virtual void attack() override;
	virtual void showParams() override;
};

