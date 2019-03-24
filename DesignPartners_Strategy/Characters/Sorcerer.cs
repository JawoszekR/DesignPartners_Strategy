using DesignPartners_Strategy.Characters.HitBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy.Characters
{
    class Sorcerer : Character
    {
        public Sorcerer(IHitBehavior hitBehavior) : base(hitBehavior)
        {
            HitPoints = 80;
            Strenght = 8;
        }
    }
}
