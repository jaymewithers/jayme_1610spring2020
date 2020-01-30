using UnityEngine;

namespace AtHomePractice
{
    public class UsingDeltaTime : MonoBehaviour
    {
        public float speed = 8f;
        public float countdown = 3.0f;
        public Light enableLight;

        void Update()
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0.0f)
                enableLight.enabled = true;

            if (Input.GetKey(KeyCode.RightArrow))
                transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            {
                
            }
        }
    }
}

// unity tutorial - using DeltaTimes with slight modifications