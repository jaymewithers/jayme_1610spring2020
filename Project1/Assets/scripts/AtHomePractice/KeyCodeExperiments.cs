using UnityEngine;

namespace AtHomePractice
{
    public class KeyCodeExperiments : MonoBehaviour
    {
        public Transform target;
        public GameObject other;
        private void Update()
        {
            if (Input.GetKey(KeyCode.H))
            {
                print("Hello World!");
            }

            if (Input.GetKey(KeyCode.Mouse0))
            {
                print("Look at that!");
                transform.LookAt(target);
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                print("Away with you!");
                Destroy(other);
            }
        }
    }
}
