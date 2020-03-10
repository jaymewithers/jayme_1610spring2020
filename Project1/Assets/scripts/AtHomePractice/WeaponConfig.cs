using UnityEngine;
using UnityEngine.Events;

namespace AtHomePractice
{
    public class WeaponConfig : MonoBehaviour
    {
        public UnityAction collectWeaponAction;
        public UnityAction weaponFireAction;
        public Color weaponColor = Color.red;
        public GameObject ammoObj;
        public Color[] colorArray;
        public float firePower = 0.1f;
        public FloatData playerHealth;

        public void RaiseFireAction()
        {
            weaponFireAction.Invoke();
        }

        public void RaiseCollectAction()
        {
            collectWeaponAction.Invoke();
        }

        public Color RandomColor()
        {
            return weaponColor;
        }
    }
}

// anthony's github