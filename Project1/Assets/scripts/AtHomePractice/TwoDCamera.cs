using UnityEngine;

namespace AtHomePractice
{
    [RequireComponent(typeof(Camera))]
    public class TwoDCamera : MonoBehaviour
    {
        private Camera cameraObj;
        private Vector3 cameraPosition;
        public Transform playerPosition;

        void Start()
        {
            cameraObj = GetComponent<Camera>();
        }

        
        void Update()
        {
            transform.position = new Vector3(playerPosition.position.x, y: 11.56f, -24);
        }
    }
}