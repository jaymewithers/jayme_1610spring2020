using UnityEngine;

public class Attack : MonoBehaviour
{
    public Health enemy, enemy2, enemy3, enemy4, enemy5;
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemy.healthValue--;
            enemy2.healthValue--;
            enemy3.healthValue--;
            enemy4.healthValue--;
            enemy5.healthValue--;
        }
    }
}