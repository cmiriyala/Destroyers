using Destroyers.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Equipment.Weapons
{
    public class Hammer : Blunt.Blunt, ISpecialItemAbility
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Hammer(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public override void SpecialAbility()
        {
            this.Stun();
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
