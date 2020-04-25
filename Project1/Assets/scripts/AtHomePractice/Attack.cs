using UnityEngine;

public class Attack : MonoBehaviour
{
    public Health enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             enemy.healthValue--;
        }
    }
}