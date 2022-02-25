using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{

    private static AudioScript instance = null;

    Scene BossScene;

    void Start()
    {
        BossScene = SceneManager.GetActiveScene();
    }

    public static AudioScript Instance 
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        BossScene = SceneManager.GetActiveScene();
        if (BossScene.name == "Level3")
        {
            Destroy(this.gameObject);
        }

        
    }
}
