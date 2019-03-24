using DesignPartners_Strategy.Characters;

namespace DesignPartners_Strategy.Weapons
{
    interface IWeapon
    {
        void Hit(Character charakterHit, Character charakterHitting);
    }
}
