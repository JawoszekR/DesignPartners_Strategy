using DesignPartners_Strategy.Characters;
using DesignPartners_Strategy.Characters.HitBehavior;
using DesignPartners_Strategy.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorcerer = new Sorcerer(new ElementsImmunityPoisonVulnerability());
            var knight = new Knight(new DefoultHitBehavior());
            var ogre = new Ogre(new DefoultHitBehavior());

            sorcerer.EquipWeapon(new Firebolt());
            knight.EquipWeapon(new Sword());
            ogre.EquipWeapon(new Club());

            
            Fight(sorcerer, ogre);
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void Fight(Character ch1, Character ch2)
        {
            Console.WriteLine("Ch1 hp:" + ch1.HitPoints + ", Ch2 hp:" + ch2.HitPoints);
            do
            {
                ch1.UseWeaponOnCharacter(ch2);
                Console.WriteLine("Ch1 hp:" + ch1.HitPoints + ", Ch2 hp:" + ch2.HitPoints);
                if (ch2.HitPoints < 0)
                    break;
                ch2.UseWeaponOnCharacter(ch1);
                Console.WriteLine("Ch1 hp:" + ch1.HitPoints + ", Ch2 hp:" + ch2.HitPoints);
            } while (ch1.HitPoints > 0 && ch2.HitPoints > 0);
        }
    }
}
