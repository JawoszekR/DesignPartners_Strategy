using DesignPartners_Strategy.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy.Weapons
{
    class Sword : IWeapon
    {
        public void Hit(Character charakterHit, Character charakterHitting)
        {
            Hit hit = new Hit(30, 90.0, EEfect.None, 100);
            charakterHit.TakeHit(hit);
        }
    }
}
