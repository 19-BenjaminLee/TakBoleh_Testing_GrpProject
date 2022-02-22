using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rb;

    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Enemy")
        {
            rb.velocity = transform.up * -Speed;
            Destroy(gameObject, 3);
        }
        else
        {
            rb.velocity = transform.right * Speed;
            Destroy(gameObject, 3);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);
            PlayerScript.Health -= 1;
        }
    }
}
