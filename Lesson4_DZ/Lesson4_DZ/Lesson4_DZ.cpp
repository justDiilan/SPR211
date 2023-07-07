#include <iostream>
#include "IntegerSet.h"
using namespace std;

int main()
{
    IntegerSet setA;
    setA += 3; // Добавление элемента 3 в множество
    setA += 8;
    setA += 46;
    setA += 5;
    setA += 11;

    IntegerSet setB;
    setB += 18; // Добавление элемента 18 в множество
    setB += 8;
    setB += 90;
    setB += 11;
    setB += 2;

    cout << "Set A: " << setA << endl;
    cout << "Set B: " << setB << endl;

    IntegerSet setC = setA + setB; // Объединение множеств
    cout << "Union (A U B): " << setC << endl;

    IntegerSet setD = setA - setB; // Разность множеств
    cout << "Difference (A - B): " << setD << endl;

    IntegerSet setE = setA * setB; // Пересечение множеств
    cout << "Intersection (A * B): " << setE << endl;

    setA += 9; // Добавление элемента 9 в множество setA
    cout << "Set A: " << setA << endl;

    setB -= 8; // Удаление элемента 8 из множества setB
    cout << "Set B: " << setB << endl;

    IntegerSet setF = setA; // Присваивание множества setA множеству setF
    cout << "Set F: " << setF << endl;

    if (setA == setF) { // Сравнение множеств
        cout << "Set A is equal to Set F" << endl;
    }

    cout << "Enter elements for Set A: ";
    cin >> setA; // Потоковый ввод множества setA

    cout << "Set A: " << setA << endl;

    return 0;
}