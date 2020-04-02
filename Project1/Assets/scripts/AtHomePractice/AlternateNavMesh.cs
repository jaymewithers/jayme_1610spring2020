using UnityEngine;
using UnityEngine.AI;

namespace AtHomePractice
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class AlternateNavMesh : MonoBehaviour
    {
        private NavMeshAgent agent;
        public Transform player;
        public float speed = 8f;
       
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.speed = speed;
        }

        
        void Update()
        {
            agent.destination = player.position;
        }
    }
}