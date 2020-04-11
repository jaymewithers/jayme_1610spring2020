using UnityEngine;

namespace AtHomePractice
{
    [RequireComponent(typeof(Camera))]
    public class TwoDCamera : MonoBehaviour
    {
        private Camera cameraObj;
        private Vector3 cameraPosition;
        public Transform playerPosition;
        public float cameraHeight = 13.8f;
        public float cameraDepth = -53;

        void Start()
        {
            cameraObj = GetComponent<Camera>();
        }

        
        void Update()
        {
            transform.position = new Vector3 (playerPosition.position.x, y: cameraHeight, cameraDepth);
        }
    }
}