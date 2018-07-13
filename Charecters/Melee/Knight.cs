using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Melee
{
    class Knight:Melee
    {

        private const string DEFAULT_NAME = "Easy";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;

        private readonly Chainlink DEFAULT_BODY_ARMOUR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();


        private Chainlink bodyArmor;
        private Hammer weapon;

        public Chainlink BodyArmor
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
        public Hammer Weapon
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


        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Knight(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {

        }
        public Knight(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOUR;

        }
        public void HolyBowl()
        {

        }
        public void PurifySoul()
        {

        }
        public void RighteousWings()
        {

        }

        public override void Attack()
        {
            this.HolyBowl();
        }

        public override void SpecialAttack()
        {
           this.PurifySoul();
        }

        public override void Defend()
        {
            this.RighteousWings();
        }
    }
}
