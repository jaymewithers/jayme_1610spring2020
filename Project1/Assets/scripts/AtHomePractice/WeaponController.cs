using Homework;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public SpriteRenderer woodSword, metalSword, laserSword;
    public CharacterWeaponSwitch currentWeapon;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            woodSword.enabled = true;
            metalSword.enabled = false;
            laserSword.enabled = false;
            currentWeapon.currentCharacterWeapon = CharacterWeaponSwitch.WeaponOptions.WoodSword;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            woodSword.enabled = false;
            metalSword.enabled = true;
            laserSword.enabled = false;
            currentWeapon.currentCharacterWeapon = CharacterWeaponSwitch.WeaponOptions.MetalSword;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            woodSword.enabled = false;
            metalSword.enabled = false;
            laserSword.enabled = true;
            currentWeapon.currentCharacterWeapon = CharacterWeaponSwitch.WeaponOptions.LaserSword;
        }
    }
}