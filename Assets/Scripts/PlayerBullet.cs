using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody2D rb;

    public GameObject Explosion;
    public GameObject Coin;

    public GameObject PowerUp;

    


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(Explosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Instantiate(Coin, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "PowerUpShip")
        {
            Instantiate(Explosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Instantiate(PowerUp, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("Boss"))
        {
            Instantiate(Explosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Instantiate(Coin, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            BossScript.Health = BossScript.Health - 1;
            Destroy(gameObject);
            if (BossScript.Health == 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
