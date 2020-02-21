using UnityEngine;

namespace AtHomePractice
{
    public class CharacterMoverPractice : MonoBehaviour
    {
        public CharacterController controller;
        public float speed = 10f;
        public float gravity = 3f;
        public float jumpForce = 3f;
        public Vector3 positionDirection;
        private int jumpCount = 0;
        public int jumpCountMax = 2;
    
        void Start()
        {
          
        }

    
        void Update()
        {
            if (controller.isGrounded)
            {
                positionDirection.y = 0;
                jumpCount = 0;
            }
            
            positionDirection.x = Input.GetAxis("Horizontal") * speed;
            
            if (Input.GetButtonDown("Jump") && jumpCount <= jumpCountMax)
            {
                positionDirection.y = jumpForce;
                jumpCount++;
            }
            
            positionDirection.y -= gravity;
            controller.Move(positionDirection * Time.deltaTime);
        }
    }
}