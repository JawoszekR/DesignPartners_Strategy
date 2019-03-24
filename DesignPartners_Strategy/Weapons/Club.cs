using DesignPatterns_Strategy.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Strategy.Weapons
{
    class Club : IWeapon
    {
        public void Hit(Character charakterHit, Character charakterHitting)
        {
            Hit hit = new Hit(5 + charakterHitting.Strenght*0.1, 80.0, EEfect.None, 100);
            charakterHit.TakeHit(hit);
        }
    }
}
