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
    

    // Shooting
    public GameObject PlayerBullet;
    public Transform FirePoint;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = "Score: " + Score.ToString();
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

    
}
