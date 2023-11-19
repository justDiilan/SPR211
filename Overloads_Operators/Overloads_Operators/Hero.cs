using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads_Operators
{
    public class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public Hero(string name, int strength)
        {
            Name = name;
            Strength = strength;
        }

        //Перевантаження оператора додавання
        public static Hero operator +(Hero hero1, Hero hero2)
        {
            return new Hero($"{hero1.Name} and {hero2.Name}", hero1.Strength + hero2.Strength);
        }

        //Перевантаження оператора віднімання
        public static Hero operator -(Hero hero, int value)
        {
            return new Hero(hero.Name, hero.Strength - value);
        }

        //Перевантаження оператора множення
        public static Hero operator *(Hero hero, int value)
        {
            return new Hero(hero.Name, hero.Strength * value);
        }

        //Перевантаження оператора ділення
        public static Hero operator /(Hero hero, int value)
        {
            if(value != 0)
                return new Hero(hero.Name, hero.Strength / value);
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

        //Перевантаження оператора порівняння на рівність
        public static bool operator ==(Hero hero1, Hero hero2)
        {
            return hero1.Strength == hero2.Strength;
        }

        //Перевантаження оператора порівняння на не рівність
        public static bool operator !=(Hero hero1, Hero hero2)
        {
            return hero1.Strength != hero2.Strength;
        }

        //Перевантаження оператора більше ніж
        public static bool operator >(Hero hero1, Hero hero2)
        {
            return hero1.Strength > hero2.Strength;
        }

        //Перевантаження оператора меньше ніж
        public static bool operator <(Hero hero1, Hero hero2)
        {
            return hero1.Strength < hero2.Strength;
        }
    }
}
