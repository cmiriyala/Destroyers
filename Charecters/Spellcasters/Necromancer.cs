using Destroyers.Enums;
using Destroyers.Equipment.Armors;
using Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Spellcasters
{
    class Necromancer:Spellcasters
    {

        private const string DEFAULT_NAME = "Pranee";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_MANAPOINTS = 100;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOUR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();


        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public LightLeatherVest BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }

        public Sword Weapon
        {
            get { return this.weapon;}
            set { this.weapon = value; }
        }

        public Necromancer()
        :this(DEFAULT_NAME,DEFAULT_LEVEL)
        {

        }
        public Necromancer(string name, int level)
        :this(name,level,DEFAULT_HEALTHPOINTS)
        {

        }
        public Necromancer(string name, int level,int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.ManaPoints = DEFAULT_MANAPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOUR;

        }
        
        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneShield()
        {

        }

        public override void Attack()
        {
            this.ShadowRage();
        }

        public override void SpecialAttack()
        {
            this.VampireTouch();        }

        public override void Defend()
        {
            this.BoneShield();
        }
    }
}
