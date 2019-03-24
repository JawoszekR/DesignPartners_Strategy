using DesignPatterns_Strategy.Characters;

namespace DesignPatterns_Strategy.Weapons
{
    interface IWeapon
    {
        void Hit(Character charakterHit, Character charakterHitting);
    }
}
