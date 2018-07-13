using System;
using System.Collections.Generic;
using Destroyers.Charecters.Melee;
using Destroyers.Charecters;
using Destroyers.Charecters.Spellcasters;

namespace Destroyers
{
    class EnteyPoint
    {
        static void Main()
        {
            Charecters.Charecters warrior = new Warrior();
            Charecters.Charecters knight= new Knight();
            Charecters.Charecters assasin = new Assasin();
     
            Charecters.Charecters mage = new Mage();
            Charecters.Charecters necromancer = new Necromancer();
            Charecters.Charecters druid = new Druid();
            
            List<Charecters.Charecters> meeleeTeam = new List<Charecters.Charecters>();
            List<Charecters.Charecters> spellCastersTeam = new List<Charecters.Charecters>();

            meeleeTeam.Add(warrior);
            meeleeTeam.Add(knight);
            meeleeTeam.Add(assasin);

            spellCastersTeam.Add(mage);
            spellCastersTeam.Add(necromancer);
            spellCastersTeam.Add(druid);

            //warrior.Attack(mage);


        }
    }
}
