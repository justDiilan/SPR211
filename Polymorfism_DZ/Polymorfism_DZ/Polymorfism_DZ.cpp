#include <iostream>
#include <string>
using namespace std;

class Weapon {
public:
    virtual void Shoot() = 0;
    virtual void Reloading() = 0;
    virtual void ShowWeapon() = 0;

protected:
    int getAmmo() { return _ammo; }
    void setAmmo(int ammo) { _ammo = ammo; }

    int getMagazines() { return _magazines; }
    void setMagazine(int magazines) { _magazines = magazines; }

    int getBarrelLength() { return _barrelLength; }
    void setBarrelLength(double barrelLength) { _barrelLength = barrelLength; }

    int getDamage() { return _damage; }
    void setDamage(int damage) { _damage = damage; }

    int _ammo;
    int _magazines;
    double _barrelLength;
    int _damage;
};

class Inventory {
public:
    virtual void ShowInventory() = 0;
};

class Pistol : public Weapon, public Inventory {
public:
    Pistol(int ammo, int magazines, double barrelLength, int damage)
        : Weapon(), Inventory() {
        _ammo = ammo;
        _magazines = magazines;
        _barrelLength = barrelLength;
        _damage = damage;
    }
    
    void Shoot() override {
        if (_ammo > 0) {
           cout << "Pistol shot! Damage: " << getDamage() << endl;
            _ammo--;
        }
        else {
            cout << "The ammo has run out. Recharge." << endl;
        }
    }

    void Reloading() override {
        if (_magazines > 0) {
            cout << "The pistol is reloaded." << endl;
            _magazines--;
            setAmmo(12);
        }
        else {
            cout << "You're out of magazines." << endl;
        }
    }

    void ShowWeapon() override {
        cout << "Pistol: " << "Ammo - " << getAmmo() << ", Magazines - " << getMagazines()
            << ", Barrel length - " << getBarrelLength() << " cm, Damage - " << getDamage() << endl;
    }

    void ShowInventory() override {
        cout << "Inventory: Ammo - " << getAmmo() << ", Magazines - " << getMagazines() << endl;
    }
};

class MachineGun : public Weapon, public Inventory {
public:
    MachineGun(int ammo, int magazines, double barrelLength, int damage)
        : Weapon(), Inventory() {
        _ammo = ammo;
        _magazines = magazines;
        _barrelLength = barrelLength;
        _damage = damage;
    }

    void Shoot() override {
        if (_ammo > 0) {
            cout << "Machine gun shot! Damage: " << getDamage() << endl;
            _ammo--;
        }
        else {
            cout << "The ammo has run out. Recharge." << endl;
        }
    }

    void Reloading() override {
        if (_magazines > 0) {
            cout << "The machine gun is reloaded." << endl;
            _magazines--;
            setAmmo(100);
        }
        else {
            cout << "You're out of magazines." << endl;
        }
    }

    void ShowWeapon() override {
        cout << "Machine gun: " << "Ammo - " << getAmmo() << ", Magazines - " << getMagazines()
            << ", Barrel length - " << getBarrelLength() << " cm, Damage - " << getDamage() << endl;
    }

    void ShowInventory() override {
        cout << "Inventory: Ammo - " << getAmmo() << ", Magazines - " << getMagazines() << endl;
    }
};

class Knife : public Weapon, public Inventory {
public:
    Knife(double barrelLength, int damage)
        : Weapon(), Inventory() {
        _barrelLength = barrelLength;
        _damage = damage;
    }

    void Shoot() override {
        cout << "Knife hit! Damage: " << getDamage() << endl;
    }

    void ShowWeapon() override {
        cout << "Knife: " << " Blade length - " << getBarrelLength() << " cm, Damage - " << getDamage() << endl;
    }

    void Reloading() override {}

    void ShowInventory() override {}
};

class Chainsaw : public Weapon, public Inventory {
public:
    Chainsaw(int ammo, int magazines, double barrelLength, int damage)
        : Weapon(), Inventory() {
        _ammo = ammo;
        _magazines = magazines;
        _barrelLength = barrelLength;
        _damage = damage;
    }

    void Shoot() override {
        if (_ammo > 0) {
            cout << "Chainsaw hit! Damage: " << getDamage() << endl;
            _ammo = _ammo - 20;
        }
        else {
            cout << "The fuel has run out. Recharge." << endl;
        }
    }

    void Reloading() override {
        if (_magazines > 0) {
            cout << "The chainsaw is reloaded." << endl;
            _magazines--;
            setAmmo(200);
        }
        else {
            cout << "You're out of canisters." << endl;
        }
    }

    void ShowWeapon() override {
        cout << "Machine gun: " << "Fuel - " << getAmmo() << ", Canisters - " << getMagazines()
            << ", Bar length - " << getBarrelLength() << " cm, Damage - " << getDamage() << endl;
    }

    void ShowInventory() override {
        cout << "Inventory: Fuel - " << getAmmo() << ", Canisters - " << getMagazines() << endl;
    }
};

void ShowInventory1(Pistol& pistol, MachineGun& machineGun, Knife& knife, Chainsaw& chainsaw) {
    cout << "Pistol: " << endl;
    pistol.ShowWeapon();
    pistol.Shoot();
    pistol.ShowInventory();
    pistol.Reloading();
    pistol.ShowInventory();
    cout << endl;

    cout << "Machine gun: " << endl;
    machineGun.ShowWeapon();
    machineGun.Shoot();
    machineGun.ShowInventory();
    machineGun.Reloading();
    machineGun.ShowInventory();
    cout << endl;

    cout << "Knife: " << endl;
    knife.Shoot();
    knife.ShowWeapon();
    cout << endl;

    cout << "Chainsaw: " << endl;
    chainsaw.ShowWeapon();
    chainsaw.Shoot();
    chainsaw.ShowInventory();
    chainsaw.Reloading();
    chainsaw.ShowInventory();
    cout << endl;
}

int main()
{
    Pistol pistol(12, 4, 10.0, 20);

    MachineGun machineGun(100, 3, 20.0, 50);

    Knife knife(12.0, 19);

    Chainsaw chainsaw(200, 2, 50.0, 50);

    ShowInventory1(pistol, machineGun, knife, chainsaw);

    return 0;
}