using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("HighScore") < 0)
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        HighScore.text = "HIGHSCORE : " + PlayerPrefs.GetInt("HighScore");
    }
}
