using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleEnemy : MonoBehaviour
{
    public float speed;
    float Limit;
    bool LimitReached;
    float currentPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position.x;
        Limit = 5f;

        if (currentPosition < Limit && LimitReached)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        else if (currentPosition > -5f && !LimitReached)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        else
        {
            LimitReached = !LimitReached;
        }
    }

    
}
