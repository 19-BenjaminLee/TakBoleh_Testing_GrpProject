using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    private float XPosition;


    // Shooting
    public GameObject PlayerBullet;
    public Transform FirePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y);


        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            //Debug.Log("Pew pew");
            Instantiate(PlayerBullet, FirePoint.position, FirePoint.rotation);
        }
    }
}
