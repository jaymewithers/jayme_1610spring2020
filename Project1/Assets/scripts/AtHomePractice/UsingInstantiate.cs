using System;
using UnityEngine;

namespace AtHomePractice
{
    public class UsingInstantiate : MonoBehaviour
    {
        public Rigidbody rocketPrefab;
        public Transform barrelEnd;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Rigidbody rocketInstance;
                rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
                rocketInstance.AddForce(barrelEnd.forward * 5000);
            }
        }
    }
}

// unity tutorial - using instantiate