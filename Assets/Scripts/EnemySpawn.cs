using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefab;  
    private float timer = 1.5f;
    Scene CurrentScene;

    // Start is called before the first frame update
    void Start()
    {
        CurrentScene = SceneManager.GetActiveScene();
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
            float spawnX = Random.Range(5, -5);
            float spawnY;

            if (CurrentScene.name != "Level3")
            {
                spawnY = 4.2f;
                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(enemyPrefab[Random.Range(0, 8)], spawnPosition, Quaternion.identity);
                timer = 1.5f;
            }
            if (CurrentScene.name == "Level3")
            {
                spawnY = 3.0f;
                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(enemyPrefab[Random.Range(0, 8)], spawnPosition, Quaternion.identity);
                timer = 2f;
            }
            
        }
    
    }
}
