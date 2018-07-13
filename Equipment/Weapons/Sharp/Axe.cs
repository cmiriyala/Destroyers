using System;
using System.Collections.Generic;
using System.Text;
using  Destroyers.Equipment.Weapons.Sharp;

namespace Destroyers.Equipment.Weapons
{
    public class Axe : Sharp.Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public override void SpecialAbility()
        {
            this.HackNSlash();
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
