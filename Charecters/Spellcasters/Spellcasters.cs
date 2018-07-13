using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Spellcasters
{
    public abstract class Spellcasters:Charecters
    {
        private int manaPoints;
        public int ManaPoints
        {
            get

            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.manaPoints = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points should be greater than or eqhal o 0 and less than 120");
                }



            }
        }
    }
}
