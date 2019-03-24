using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy.Characters.HitBehavior
{
    interface IHitBehavior
    {
        void Hit(Character charakter);
    }
}
