

namespace Destroyers.Equipment.Armors
{
   public class Chainlink:Heavy.Heavy
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public Chainlink()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}