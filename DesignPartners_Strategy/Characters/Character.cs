using DesignPatterns_Strategy.Characters.HitBehavior;
using DesignPatterns_Strategy.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Strategy.Characters
{
    abstract class Character
    {
        IWeapon weapon;
        IHitBehavior hitBehavior;

        public double HitPoints { get; set; }
        public int Strenght { get; set; }

        public Character(IHitBehavior hitBehavior)
        {
            this.hitBehavior = hitBehavior;
        }

        public Character(IHitBehavior hitBehavior, IWeapon equippedWeapon)
            : this(hitBehavior)
        {
            weapon = equippedWeapon;
        }

        public void EquipWeapon(IWeapon equippedWeapon)
        {
            weapon = equippedWeapon;
        }

        public void TakeHit(Hit weaponHit)
        {
            hitBehavior.Hit(this, weaponHit);
        }

        public void UseWeaponOnCharacter(Character characterHit)
        {
            weapon.Hit(characterHit, this);
        }
    }
}
