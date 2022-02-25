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

    public void Tummy()
    {
        Application.OpenURL("https://opengameart.org/users/tummyache");
    }

    public void Scientist()
    {
        Application.OpenURL("https://opengameart.org/users/thescientist");
    }

    public void GameTheme()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=p8moocGzQJ4&t=2s");
    }

    public void BossTheme()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=9--lKyEphWY");
    }
}
