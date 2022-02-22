using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    // Timer //
    public Text timerTxt;
    float timer = 30;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // game lose condition //
        timerTxt.text = "Timer: " + timer.ToString("0");
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("Level2");
        }
       

        if (PlayerScript.Health <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
