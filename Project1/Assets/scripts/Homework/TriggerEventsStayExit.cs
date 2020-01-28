using UnityEngine;

namespace Homework
{
    public class TriggerEventsStayExit : MonoBehaviour
    {
        public void OnTriggerStay(Collider other)
        {
            if (other.attachedRigidbody)
            {
                print("Attack!");
            }
        }

        public void OnTriggerExit(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}

// help from unity's website
