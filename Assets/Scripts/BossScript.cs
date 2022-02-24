using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript : MonoBehaviour
{
   
    public int MaxHealth;

    public static int Health = 0;


    public float speed;
    float Limit;
    bool LimitReached;
    float currentPosition;

    public Slider HealthBar;
    public Text HealthTxt;

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        HealthBar.maxValue = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthTxt.text = Health + " / " + MaxHealth;
        HealthBar.value = Health;
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
