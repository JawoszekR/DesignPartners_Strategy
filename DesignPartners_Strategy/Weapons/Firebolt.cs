using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPartners_Strategy.Characters;

namespace DesignPartners_Strategy.Weapons
{
    class Firebolt : IWeapon
    {
        public void Hit(Character charakterHit, Character charakterHitting)
        {
            Hit hit = new Hit(50, 75.1, EEfect.Fire, 50);
            charakterHit.TakeHit(hit);
        }
    }
}
