using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;

namespace Destroyers.Charecters.Melee
{
    class Warrior:Melee
    {
        private const string DEFAULT_NAME= "Cheth";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS= 100;

        private readonly Chainlink DEFAULT_BODY_ARMOUR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();


        private Chainlink bodyArmor;
        private Axe weapon;

       

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
        public Axe Weapon
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

        public Warrior()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
           

        }
        public Warrior(string name, int level)
            :this( name, level, DEFAULT_HEALTHPOINTS)
        {

        }
        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOUR;


        }
        public void Strike()
        {

        }
        public void Execute()
        {

        }
        public void SkinHarden()
        {

        }

        public override void Attack()
        {
            this.Strike();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }
    }
}
