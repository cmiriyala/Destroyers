using System;
using System.Collections.Generic;
using System.Text;

namespace Destroyers.Charecters.Melee
{
    public abstract class Melee:Charecters
    {


        private int abilityPoints;
        public int AbilityPoints
        {
            get

            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.abilityPoints = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points should be greater than or eqhal o 0 and less than 120");
                }



            }
        }
    }
}
