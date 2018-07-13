using System;
using System.Collections.Generic;
using System.Text;
using Destroyers.Charecters.interfaces;
using Destroyers.Enums;

namespace Destroyers.Charecters
{
    public abstract class Charecters : IAttack, IDefend
    {
        

        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;
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

        public abstract void Attack();


        public abstract void SpecialAttack();

        public abstract void Defend();
    }
}
