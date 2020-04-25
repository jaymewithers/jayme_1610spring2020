using System;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    public FloatData value;
    public Vector3 startPoint;

    private void Start()
    {
        startPoint = player.transform.position;
    }

    void Update()
    {
        if (value.value <= 0)
        {
            player.transform.position = startPoint;
        }

        if (player.transform.position == startPoint)
        {
            value.value = 1;
        }
    }
}