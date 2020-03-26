using UnityEngine;
using UnityEngine.AI;

namespace Homework
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NavMeshPractice : MonoBehaviour
    {
        private NavMeshAgent agent;
        public Vector3 destination;
        public float speed = 10f;
        public float radius = 5f;
        private float angularSpeed = 0f;
        public Vector3 secondDestination;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.speed = speed;
            agent.radius = radius;
            agent.angularSpeed = angularSpeed;
            agent.nextPosition = secondDestination;
        }

        
        void Update()
        {
            agent.destination = destination;
        }
    }
}