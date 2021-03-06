﻿using System.Collections;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public int coinCount;

    IEnumerator coinCheck ()
    {
        while (coinCount < 30)
        {
            print("Get all the coins!");
            yield return new WaitForSeconds(5);
        }

        if (coinCount == 30)
        {
            print("All coins collected.");
        }
    }
}