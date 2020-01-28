using UnityEngine;

namespace AtHomePractice
{
    public class ColorChanger : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                GetComponent<Renderer>().material.color = Color.red;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                GetComponent<Renderer>().material.color = Color.green;
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }
}

// unity tutorial - scripts as behaviour components