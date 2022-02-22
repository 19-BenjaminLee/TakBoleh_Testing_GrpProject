using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Transform enemyBullet;
    public Transform enemyFirePoint;

    public float timer = 0;
    public float timeBtwShots = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBtwShots)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        timer = 0;
        Instantiate(enemyBullet, enemyFirePoint.position, enemyFirePoint.rotation);
    }
}
