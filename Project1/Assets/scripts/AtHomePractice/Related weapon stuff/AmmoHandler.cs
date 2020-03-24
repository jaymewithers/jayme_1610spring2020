using UnityEngine;

namespace AtHomePractice.Related_weapon_stuff
{
    [RequireComponent(typeof(Rigidbody))]
    public class AmmoHandler : MonoBehaviour
    {
        private Rigidbody rigidbodyObj = new Rigidbody();
        public Vector3 forces;
        
        void Start()
        {
            rigidbodyObj.GetComponent<Rigidbody>();
            rigidbodyObj.AddForce(forces);
            Destroy(gameObject, 1f);
        }
    }
}

// anthony's github