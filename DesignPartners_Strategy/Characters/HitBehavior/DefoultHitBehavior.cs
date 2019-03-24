using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy.Characters.HitBehavior
{
    class DefoultHitBehavior : IHitBehavior
    {
        public void Hit(Character charakter, Hit weaponHit)
        {
            switch (weaponHit.Efect)
            {
                case EEfect.None:
                    charakter.HitPoints -= weaponHit.Damage;
                    break;
                case EEfect.Fire:
                    charakter.HitPoints -= (weaponHit.Damage + 10);
                    break;
                case EEfect.Freeze:
                    charakter.HitPoints -= (weaponHit.Damage + 10);
                    break;
                case EEfect.Poison:
                    charakter.HitPoints -= (weaponHit.Damage + 10);
                    break;
                default:
                    break;
            }
        }
    }
}
