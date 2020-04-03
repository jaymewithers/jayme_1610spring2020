using System;
using Behaviors;
using UnityEngine;

namespace AtHomePractice
{
    public class EnemyAI : MonoBehaviour
    {
        public enum EnemyStates
        {
            Patrolling,
            Chasing,
            Attacking,
            Defeated
        }

        public EnemyStates currentEnemyState;
    
        void Start()
        {
            currentEnemyState = EnemyStates.Chasing;
        }

    
        void Update()
        {
            switch (currentEnemyState)
            {
                case EnemyStates.Patrolling:
                    print("Patrolling");
                    break;
                case EnemyStates.Chasing:
                    print("Chasing");
                    break;
                case EnemyStates.Attacking:
                    print("Attacking");
                    break;
                case EnemyStates.Defeated:
                    print("Defeated");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}

// unity tutorial