using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    private float XPosition;

    // Score //
    public Text scoreTxt;
    public static int Score;
   

    // Health //
    public Text healthTxt;
    public static int Health = 3;


    bool HasPowerUp = false;

    // Shooting
    public GameObject PlayerBullet;
    public Transform FirePoint;


    // Power Up
    public Transform Power1;
    public Transform Power2;

    public GameObject PowerUpShip;

    // Audio clips
    public AudioClip[] AudioClipArr;
    private AudioSource audiosource;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = "Score: " + Score.ToString();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        scoreTxt.text = "Score: " + Score.ToString();

        healthTxt.text = "Health X " + Health.ToString();

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -5f, 5f), transform.position.y);

        // Left click to shoot //
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Instantiate(PlayerBullet, FirePoint.position, FirePoint.rotation);
        }

        
        // game win condition //

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PowerUp" && HasPowerUp == false)
        {
            StartCoroutine(PowerUpPickUp(collision));
            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.tag == "Score")
        {
            audiosource.PlayOneShot(AudioClipArr[0]);
        }

        if (collision.gameObject.tag == "PowerUp")
        {
            audiosource.PlayOneShot(AudioClipArr[1]);
        }

        if (collision.gameObject.tag == "Health")
        {
            audiosource.PlayOneShot(AudioClipArr[2]);
        }
    }



    IEnumerator PowerUpPickUp(Collider2D PowerUp)
    {
        HasPowerUp = true;
        GameObject power1 = Instantiate(PowerUpShip, Power1.transform.position, Power1.transform.rotation);
        GameObject power2 = Instantiate(PowerUpShip, Power2.transform.position, Power2.transform.rotation);

        power1.transform.parent = gameObject.transform;
        power2.transform.parent = gameObject.transform;
        //Debug.Log("Powerup On");

        yield return new WaitForSeconds(10f);

        //Debug.Log("Powerup off");

        Destroy(power1);
        Destroy(power2);

        HasPowerUp = false;
    }
}
