using UnityEngine;

namespace AtHomePractice
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
// continue with other related scripts (weaponbuttonhandler, ammohandler) from 2670Fall2019

// anthony's github