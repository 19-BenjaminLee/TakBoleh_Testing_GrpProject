using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShip : MonoBehaviour
{
    public GameObject ShipBullet;
    public Transform FirePoint;

    public float timer = 0;
    public float timeBtwShots;
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
        Instantiate(ShipBullet, FirePoint.transform.position, FirePoint.transform.rotation);
    }
}
