using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Spellcasters
{
    class Mage:Spellcasters
    {
        private const string DEFAULT_NAME = "Vijay";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_MANAPOINTS = 100;

        private readonly ClothRobe DEFAULT_BODY_ARMOUR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();


        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Staff Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }



        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {


        }
        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {

        }
        public Mage(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.ManaPoints = DEFAULT_MANAPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOUR;


        }

        public void ArcaneWrath()
        {

        }
        public void Firewall()
        {

        }
        public void Mediation()
        {

        }

        public override void Attack()
        {
            this.ArcaneWrath();
        }

        public override void SpecialAttack()
        {
            this.Firewall();

        }

        public override void Defend()
        {
            this.Mediation();
        }
    }
}
