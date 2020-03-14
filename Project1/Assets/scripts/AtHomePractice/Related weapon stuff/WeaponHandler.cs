using UnityEngine;

namespace AtHomePractice.Related_weapon_stuff
{
    public class WeaponHandler : MonoBehaviour
    {
        public WeaponConfig weaponObj;

        void Start()
        {
            weaponObj.weaponFireAction = Fire;
            var renderer = GetComponent<Renderer>();
            renderer.material.color = weaponObj.weaponColor;
        }

        private void Fire()
        {
            var ammo = Instantiate(weaponObj.ammoObj);
            var renderer = ammo.GetComponent<Renderer>();
            renderer.material.color = weaponObj.RandomColor();
        }

        private void OnTriggerEnter(Collider other)
        {
            weaponObj.RaiseCollectAction();
        }
    }
}

// anthony's github