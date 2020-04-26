using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    public FloatData value;
    public IntData coins;

    void Update()
    {
        if (!(value.value <= 0)) return;
        SceneManager.LoadScene("Level1");
        value.value = 1;
        coins.value = 0;
    }
}