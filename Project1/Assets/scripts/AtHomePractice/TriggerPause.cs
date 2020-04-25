using UnityEngine;

public class TriggerPause : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        print("Game Completed! Congratulations!");
    }
}