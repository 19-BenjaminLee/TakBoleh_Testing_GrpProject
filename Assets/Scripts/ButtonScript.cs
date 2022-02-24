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
        SceneManager.LoadScene("Level1");
    }

    public void ClearHighscore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
