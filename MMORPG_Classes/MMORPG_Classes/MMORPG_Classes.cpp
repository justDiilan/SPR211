#include <iostream>
#include "Hero.h"
#include "Assassin.h"
#include "Chanter.h"
#include "Cleric.h"
#include "Gladiator.h"
#include "Ranger.h"
#include "Sorcerer.h"
#include "Spiritmaster.h"
#include "Templar.h"
using namespace std;

void eventPerformance(Hero& hero)
{
    hero.attack();
    hero.showParams();
    cout << endl;
}

int main()
{
    Assassin assassin("Assassin", 0, 70, 80);
    Chanter chanter("Chanter", 40, 20, 110);
    Cleric cleric("Cleric", 60, 10, 85);
    Gladiator gladiator("Gladiator", 0, 120, 150);
    Ranger ranger("Ranger", 0, 80, 90);
    Sorcerer sorcerer("Sorcerer", 120, 30, 65);
    Spiritmaster spiritmaster("Spiritmaster", 150, 15, 70);
    Templar templar("Templar", 0, 110, 120);

    eventPerformance(templar);
    eventPerformance(gladiator);
    eventPerformance(sorcerer);
    eventPerformance(spiritmaster);
    eventPerformance(chanter);
    eventPerformance(cleric);
    eventPerformance(assassin);
    eventPerformance(ranger);

    return 0;
}