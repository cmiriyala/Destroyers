using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;

namespace Destroyers.Charecters.Melee
{
    class Warrior
    {
        private const string DEFAULT_NAME= "Cheth";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS= 100;

        private readonly Chainlink DEFAULT_BODY_ARMOUR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

        public int AbilityPoints
        {
            get

            {
                return this.abilityPoints;
            }
            set
            {
                if( value >=0 && value<=120)
                {
                    this.abilityPoints = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty,"Ability Points should be greater than or eqhal o 0 and less than 120");
                }



            }
        }
        public int HealthPoints
        {
            get

            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 10 && value <= 100)
                {
                    this.healthPoints = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points should be greater than or eqhal to 10 and less than 100");
                }



            }
        }

        public int Level
        {
            get

            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    this.level = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Level should be greater than or eqhal to 1 and less than or equal to 10");
                }



            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                
                this.faction = value;
               
            }
        }

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
    }
}
