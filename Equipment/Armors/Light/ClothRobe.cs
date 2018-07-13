using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Equipment.Armors
{
    public class ClothRobe:Light.Light
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
