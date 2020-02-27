using UnityEngine;

namespace AtHomePractice
{
    [RequireComponent(typeof(Rigidbody))]
    public class FollowBehaviour : MonoBehaviour
    {
        private Rigidbody rigidbodyObj;
        public float movementSpeed = 5;
        public Transform target;
        private float maxDistance = 1.5f;
        
        void Start()
        {
            rigidbodyObj = GetComponent<Rigidbody>();
        }
        
        void Update()
        {
            transform.LookAt(target.position);
            if ((transform.position - target.position).magnitude > maxDistance)
                transform.Translate(0.0f, 0.0f, movementSpeed * Time.deltaTime);
            
        }
    }
}

// help from unity tutorial - following an object