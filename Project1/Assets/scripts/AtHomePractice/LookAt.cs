using UnityEngine;

namespace AtHomePractice
{
    public class LookAt : MonoBehaviour
    {
        public Transform target;
    
        void Update()
        {
            if (Input.GetKey(KeyCode.L))
            {
                 transform.LookAt(target);
            }
           
        }
    }
}

// unity tutorial - look at