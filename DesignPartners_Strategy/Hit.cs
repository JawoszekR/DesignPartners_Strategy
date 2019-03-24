using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy
{
    class Hit
    {
        public double Damage { get; set; }
        public double HitChance { get; set; }
        public EEfect Efect { get; set; }
        public double EfectChance { get; set; }

        public Hit(double damage, double hitChance, EEfect hitAdditionalEfect, double efectChance)
        {
            Damage = damage;
            HitChance = hitChance;
            Efect = hitAdditionalEfect;
            EfectChance = efectChance;
        }
    }
}
