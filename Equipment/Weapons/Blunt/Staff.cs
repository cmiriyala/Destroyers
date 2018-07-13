using System;
using System.Collections.Generic;
using System.Text;
using Destroyers.Equipment.Interfaces;

namespace Destroyers.Equipment.Weapons
{
    public class Staff : Blunt.Blunt, IBuff
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Staff(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public override void SpecialAbility()
        {
            this.Buff();
        }

        public void Buff()
        {
            this.Empower();
            // More buff abilities...
            // ...
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
