using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elven_Mystic
{
    public class ElvenMystic
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Karma { get; set; }
        public string Weapon { get; set; }

        public ElvenMystic(string name, int health, int karma, string weapon)
        {
            Name = name;
            Health = health;
            Karma = karma;
            Weapon = weapon;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public virtual void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class ElvenOracle : ElvenMystic
    {
        public ElvenOracle(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} uses divine powers!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class ElvenElder : ElvenOracle
    {
        public ElvenElder(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} channels ancient elven energy!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class EvasSaint : ElvenElder
    {
        public EvasSaint(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} invokes the blessings of Evas!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class ElvenWizard : ElvenMystic
    {
        public ElvenWizard(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} casts powerful wizard spells!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class ElementalSummoner : ElvenWizard
    {
        public ElementalSummoner(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} summons elemental forces!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class SpellSinger : ElvenWizard
    {
        public SpellSinger(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} sings magical incantations!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class ElementalMaster : ElementalSummoner
    {
        public ElementalMaster(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} commands mastery over elements!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }

    public class MysticMuse : SpellSinger
    {
        public MysticMuse(string name, int health, int karma, string weapon) : base(name, health, karma, weapon) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} becomes a muse of mystical melodies!");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} speaks!");
        }
        public override void Stats()
        {
            Console.WriteLine($"{Name} use {Weapon}, it has {Karma} karma point and {Health} health point!");
        }
    }
}
