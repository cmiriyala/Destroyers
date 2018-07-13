using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Spellcasters
{
    class Druid:Spellcasters
    {

        private const string DEFAULT_NAME = "Bunty";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_MANAPOINTS = 100;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOUR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LightLeatherVest bodyArmor;
        private Staff weapon;

        public LightLeatherVest BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }

        public Staff Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public Druid()
        :this(DEFAULT_NAME,DEFAULT_LEVEL)
        {
        
        }

        public Druid(string name, int level)
        :this(name,level,DEFAULT_HEALTHPOINTS)
        {
            
        }
        public Druid(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.ManaPoints = DEFAULT_MANAPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOUR;
        }

        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithTheNature()
        {

        }

        public override void Attack()
        {
            this.Moonfire();
        }

        public override void SpecialAttack()
        {
            this.Starburst();
        }

        public override void Defend()
        {
            this.OneWithTheNature();
        }
    }
}
