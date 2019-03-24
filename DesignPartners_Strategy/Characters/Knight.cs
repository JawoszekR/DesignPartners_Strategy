using DesignPatterns_Strategy.Characters.HitBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Strategy.Characters
{
    class Knight : Character
    {
        public Knight(IHitBehavior hitBehavior ) : base(hitBehavior)
        {
            HitPoints = 100;
            Strenght = 20;
        }
    }
}
