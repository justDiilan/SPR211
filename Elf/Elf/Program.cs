using System;
using Elven_Mystic;

namespace Elf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElvenWizard elvenWizard = new ElvenWizard("Elven Wizard", 100, 100, "Staff");
            elvenWizard.Attack();
            elvenWizard.Speak();
            elvenWizard.Stats();

            ElementalSummoner summoner = new ElementalSummoner("Elemental Summoner", 120, 90, "Elementary particles");
            summoner.Attack();
            summoner.Speak();
            summoner.Stats();

            ElementalMaster elementalMaster = new ElementalMaster("Elemental Master", 80, 80, "Magic book");
            elementalMaster.Attack();
            elementalMaster.Speak();
            elementalMaster.Stats();

            SpellSinger spellSinger = new SpellSinger("Spell Singer", 70, 120, "Voice");
            spellSinger.Attack();
            spellSinger.Speak();
            spellSinger.Stats();

            MysticMuse mysticMuse = new MysticMuse("Mystic Muse", 70, 100, "Harp");
            mysticMuse.Attack();
            mysticMuse.Speak();
            mysticMuse.Stats();

            ElvenOracle elvenOracle = new ElvenOracle("Elven Oracle", 60, 50, "Alchemy");
            elvenOracle.Attack();
            elvenOracle.Speak();
            elvenOracle.Stats();

            ElvenElder elvenElder = new ElvenElder("Elven Elder", 80, 50, "Magic scrolls");
            elvenElder.Attack();
            elvenElder.Speak();
            elvenElder.Stats();

            EvasSaint evasSaint = new EvasSaint("Elven Saint", 100, 60, "Prayer");
            evasSaint.Attack();
            evasSaint.Speak();
            evasSaint.Stats();

            Console.ReadKey();
        }
    }
}
