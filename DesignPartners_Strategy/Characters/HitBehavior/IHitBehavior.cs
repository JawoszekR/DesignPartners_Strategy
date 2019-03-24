using DesignPatterns_Strategy.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Strategy.Characters.HitBehavior
{
    interface IHitBehavior
    {
        void Hit(Character charakter, Hit weaponHit);
    }
}
