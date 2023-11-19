using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Hero 1", 100);
            Hero hero2 = new Hero("Hero 2", 150);

            //Додавання сил героїв
            Hero heroCombine = hero1 + hero2;
            Console.WriteLine($"Combine Hero: {heroCombine.Name}, Strength: {heroCombine.Strength}");

            //Віднімання (ослаблення) героя
            Hero weakeningHero = hero1 - 50;
            Console.WriteLine($"Weakening hero: {weakeningHero.Name}, Strength: {weakeningHero.Strength}");

            //Множення (збільшення сил) героя
            Hero gainHero = hero1 * 2;
            Console.WriteLine($"Gain hero: {gainHero.Name}, Strength: {gainHero.Strength}");

            //Ділення (ослабення) героя
            Hero weakeningHeroX2 = hero2 / 50;
            Console.WriteLine($"Weakening hero X2: {weakeningHeroX2.Name}, Strength: {weakeningHeroX2.Strength}");

            //Порівняння сил героїв
            Console.WriteLine($"{hero1.Name} == {hero2.Name}: {hero1 == hero2}");
            Console.WriteLine($"{hero1.Name} != {hero2.Name}: {hero1 != hero2}");
            Console.WriteLine($"{hero1.Name} > {hero2.Name}: {hero1 > hero2}");
            Console.WriteLine($"{hero1.Name} < {hero2.Name}: {hero1 < hero2}");

            Console.ReadKey();
        }
    }
}
