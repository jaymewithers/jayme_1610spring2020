﻿using System.Collections;
using UnityEngine;

namespace AtHomePractice
{
    public class ForLoopTutorial : MonoBehaviour
    {
        public int count;
        
        void Start()
        {
            StartCoroutine(AddToCount());
        }

        IEnumerator AddToCount()
        {
            for (int i = 0; i < 100; i++)
            {
                count++;
                yield return new WaitForSeconds(0.5f);
            }
        }

        private void Update()
        {
            if (count == 80)
            {
                print("Faster! Hurry!");
            }
        }
    }
}

// unity tutorial - for loops