using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AtHomePractice
{
    public class Spawn : MonoBehaviour
    {
        public List<GameObject> spawnPoints;
        public List<GameObject> enemies;
        public bool canSpawn;
        public float spawnTimeMin;
        public float spawnTimeMax;
        

        void Start()
        {
            canSpawn = true;
            StartCoroutine(RandSpawn());
        }

        void SpawnEnemy()
        {
            var spawnPointNumber = Random.Range(0, spawnPoints.Count);
            var spawnPoint = spawnPoints[spawnPointNumber];
            var enemyNumber = Random.Range(0, enemies.Count);
            var enemy = enemies[enemyNumber];
            Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity);
        }

        IEnumerator RandSpawn()
        {
            while (canSpawn == true)
            {
                var spawnTime = Random.Range(spawnTimeMin, spawnTimeMax);
                SpawnEnemy();
                yield return new WaitForSeconds(spawnTime);
            }
        }
    }
}

// anthony's github