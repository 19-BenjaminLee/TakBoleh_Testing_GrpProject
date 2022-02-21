using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefab;  
    private float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemySpawner();
    }

    void EnemySpawner()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            float spawnX = Random.Range(7, -7);
            float spawnY = 4.2f;

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(enemyPrefab[Random.Range(0, 3)], spawnPosition, Quaternion.identity);
            timer = 2f;
        }
    
    }
}
