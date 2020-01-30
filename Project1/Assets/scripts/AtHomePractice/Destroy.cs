using UnityEngine;

namespace AtHomePractice
{
    public class Destroy : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(GetComponent<MeshRenderer>());
            }
        }
    }
}

// unity tutorial - destroy