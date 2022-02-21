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

    public Text timerTxt;
    float timer = 30;

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

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y);

        // Left click to shoot //
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Instantiate(PlayerBullet, FirePoint.position, FirePoint.rotation);
        }

        // game lose condition //
        timerTxt.text = "Timer: " + timer.ToString("0");
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        // game win condition //

    }
}
