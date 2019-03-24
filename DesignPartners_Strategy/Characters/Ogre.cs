using DesignPartners_Strategy.Characters.HitBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy.Characters
{
    class Ogre : Character
    {
        public Ogre(IHitBehavior hitBehavior) : base(hitBehavior)
        {
            HitPoints = 200;
            Strenght = 150;
        }
    }
}
