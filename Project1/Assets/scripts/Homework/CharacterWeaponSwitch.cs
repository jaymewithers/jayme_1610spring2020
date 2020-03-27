using System;
using UnityEngine;
using UnityEngine.Events;

namespace Homework
{
    public class CharacterWeaponSwitch : MonoBehaviour
    {
        public UnityEvent woodSwordEvent, metalSwordEvent, laserSwordEvent;
        
        public enum WeaponOptions
        {
            WoodSword,
            MetalSword,
            LaserSword
        }

        public WeaponOptions currentCharacterWeapon;

        void Update()
        {
            switch (currentCharacterWeapon)
            {
                case WeaponOptions.WoodSword:
                    woodSwordEvent.Invoke();
                    print("Wood sword equipped.");
                    break;
                case WeaponOptions.MetalSword:
                    metalSwordEvent.Invoke();
                    print("Metal sword equipped.");
                    break;
                case WeaponOptions.LaserSword:
                    laserSwordEvent.Invoke();
                    print("Laser sword equipped.");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}