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
    Scene CurrentScene;

    // Start is called before the first frame update
    void Start()
    {

        // Get The Current Scene Name //
        CurrentScene = SceneManager.GetActiveScene();
        Debug.Log(CurrentScene.name);
        Debug.Log(PlayerPrefs.GetInt("Level1Score"));

        if (CurrentScene.name == "Level3")
        {
            PlayerScript.Health = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        // Game Lose / Win Condition Level 1 //
        if (CurrentScene.name == "Level1")
        {

        timerTxt.text = "Timer: " + timer.ToString("0");
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
                PlayerPrefs.SetInt("Level1Score", PlayerScript.Score);
            SceneManager.LoadScene("Level2");

        }

        if (PlayerScript.Health <= 0)
        {

            SceneManager.LoadScene("GameOverScene");

        }

        }

        // Game Lose / Win Condition Level 2 //
        if (CurrentScene.name == "Level2")
        {

            if(PlayerScript.Score == PlayerPrefs.GetInt("Level1Score") + 200)
            {
                PlayerPrefs.SetInt("Level1Score", 0);
                SceneManager.LoadScene("Level3");
            }

            if(PlayerScript.Health <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }

        // Game Lose / Win Condition Level 3 //
        if (CurrentScene.name == "Level3")
        {
            
            if(PlayerScript.Health <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }

        }
    }
}
