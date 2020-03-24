using System;
using UnityEngine;
using UnityEngine.Events;

namespace Homework
{
    public class WeaponSwitch : MonoBehaviour
    {
        public UnityEvent swordEvent, blasterEvent, gunEvent;

        public enum WeaponOptions
        {
            Sword,
            Blaster,
            Gun,
        }

        public WeaponOptions currentWeaponOption;
        
   
        void Update()
        {
            switch (currentWeaponOption)
            {
                case WeaponOptions.Sword:
                    swordEvent.Invoke();
                    break;
                case WeaponOptions.Blaster:
                    blasterEvent.Invoke();
                    break;
                case WeaponOptions.Gun:
                    gunEvent.Invoke();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}