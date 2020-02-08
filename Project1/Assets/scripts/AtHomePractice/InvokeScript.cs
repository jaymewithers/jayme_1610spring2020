using UnityEngine;
using Random = UnityEngine.Random;

namespace AtHomePractice
{
    public class InvokeScript : MonoBehaviour
    {
        public GameObject target;

        
        void Start()
        {
            InvokeRepeating("SpawnObject", 2, 1);
        }

        
        void SpawnObject()
        {
            float x = Random.Range(-4.0f, 4.0f);
            float z = Random.Range(-4.0f, 4.0f);
            Instantiate(target, new Vector3(x, 5, z), Quaternion.identity);
        }
    }
}

// unity tutorial - invoke