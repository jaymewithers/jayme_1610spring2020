using UnityEngine;

namespace AtHomePractice
{
[RequireComponent(typeof(CharacterController))]
    public class Practice : MonoBehaviour
    {
        private CharacterController controller;
        private Vector3 positionDirection;
        private float gravity = 3f;
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

   
        void Update()
        {
            if (Input.GetKey(KeyCode.Backspace))
            {
                positionDirection.x = 0;
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                positionDirection.x = -5;
            }

            if (Input.GetKey(KeyCode.RightShift))
            {
                positionDirection.x = 5;
            }

            positionDirection.y -= gravity;
            controller.Move(positionDirection * Time.deltaTime);
        }
    }
}