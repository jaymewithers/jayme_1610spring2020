using UnityEngine;

namespace AtHomePractice
{
    public class Pause : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Time.timeScale = 0;
                print("Paused.");
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                print("Resumed.");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Time.timeScale = 0.25f;
                print("Slow motion.");
            }
        }
    }
}

// unity tutorial - pause system
// attach to camera