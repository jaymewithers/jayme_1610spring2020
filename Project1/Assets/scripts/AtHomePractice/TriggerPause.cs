using System.Collections;
using UnityEngine;

public class TriggerPause : MonoBehaviour
{
    IEnumerator OnTriggerEnter(Collider other)
    {
        print("Game Completed! Congratulations!");
        yield return new  WaitForSeconds(5);
        Time.timeScale = 0;
    }
}