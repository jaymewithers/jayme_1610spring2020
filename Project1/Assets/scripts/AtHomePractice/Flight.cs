using UnityEngine;

namespace AtHomePractice
{
    [RequireComponent(typeof(CharacterController))]
    public class Flight : MonoBehaviour
    {
        private CharacterController controller;
        public float flightSpeed = 4f;
        public Vector3 positionDirection;
        public float speed = 3f;
        public float flightForce = 5f;
        public float gravity = 0.02f;

        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        public virtual void ChangePosition()
        {
            transform.position += new Vector3(0, flightSpeed, 0);
        }

        private void Update()
        {
            ChangePosition();
            positionDirection.x = Input.GetAxis("Horizontal") * speed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                positionDirection.y = flightForce;
            }

            positionDirection.y -= gravity;
            controller.Move(positionDirection * Time.deltaTime);
        }
    }
}
