using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Melee
{
    class Assasin:Melee
    {

        private const string DEFAULT_NAME = "Susheel";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOUR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LightLeatherVest bodyArmor;
        private Sword weapon;


        public LightLeatherVest BodyArmor
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
        public Sword Weapon
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

    


        public Assasin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {


        }
        public Assasin(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {

        }
        public Assasin(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOUR;


        }


        public void Raze()
        {

        }
        public void BleedToDeath()
        {

        }
        public void Survival()
        {

        }

        public override void Attack()
        {
            this.Raze();

        }

        public override void SpecialAttack()
        {
            this.BleedToDeath();
        }

        public override void Defend()
        {
            this.Survival();
        }
    }
}
