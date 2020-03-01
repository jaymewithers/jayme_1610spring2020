using UnityEngine;

namespace AtHomePractice
{
    [RequireComponent(typeof(Rigidbody))]
    public class Enemy : MonoBehaviour
    {
        public float speed = 3f;
        private Rigidbody enemyRb;
        private GameObject player;

        void Start()
        {
            enemyRb = GetComponent<Rigidbody>();
            player = GameObject.Find("Player");
        }


        void Update()
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;

            enemyRb.AddForce(lookDirection * speed);
        }
    }
}

// unity tutorial