using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Main Menu Button \\

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    // Replay Button \\

    public void Replay()
    {

        PlayerScript.Score = PlayerPrefs.GetInt("PreviousScore");

        if (PlayerPrefs.GetInt("CurrentLevel") == 1)
        SceneManager.LoadScene("Level1");
        if (PlayerPrefs.GetInt("CurrentLevel") == 2)
            SceneManager.LoadScene("Level2");
        if (PlayerPrefs.GetInt("CurrentLevel") == 3)
            SceneManager.LoadScene("Level3");
        if (PlayerPrefs.GetInt("CurrentLevel") == 4)
            SceneManager.LoadScene("Level1");
    }

    public void ClearHighscore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
