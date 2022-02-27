using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

//#if UNITY_EDITOR
public class SkinManager : MonoBehaviour
{
    //public SpriteRenderer sr;
    //public List<Sprite> skins = new List<Sprite>();
    //private int selectedSkin = 0;

    //public GameObject playerskin;

    public GameObject[] characters;
    public int selectedCharacter = 0;


    public void NextOption()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);

        //selectedSkin = selectedSkin + 1;
        //if (selectedSkin == skins.Count)
        //{
        //    selectedSkin = 0;
        //}
        //PlayerPrefs.SetInt("skinIndex", selectedSkin);
        //sr.sprite = skins[selectedSkin];


    }


    public void BackOption()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);

        //selectedSkin = selectedSkin - 1;
        //if (selectedSkin < 0)
        //{
        //    selectedSkin = skins.Count - 1;
        //}
        //PlayerPrefs.SetInt("skinIndex", selectedSkin);
        //sr.sprite = skins[selectedSkin];
    }



    public void PlayGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);

        //PlayerPrefs.SetInt("skinIndex", selectedSkin);
        ////PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Prefabs/selectedskin.prefab");
        SceneManager.LoadScene("Level1");
    }

    public void PlayEndless()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);

        //PlayerPrefs.SetInt("skinIndex", selectedSkin);
        //PlayerScript.Score = 0;
        ////PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Prefabs/selectedskin.prefab");
        SceneManager.LoadScene("Level4");
    }
}

//#endif
