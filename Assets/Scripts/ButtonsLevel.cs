using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsLevel : MonoBehaviour {

    public static int releasedLevelStatic = 1;
    public int releasedLevel;
    public string nextLevel;
    public string replayLevel;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            releasedLevelStatic = PlayerPrefs.GetInt("Level", releasedLevelStatic);
        }
    }

    public void ButtonNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
        if ( releasedLevelStatic <= releasedLevel)
        {
            releasedLevelStatic = releasedLevel;
        }
        PlayerPrefs.SetInt("Level", releasedLevelStatic);
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene("Menu");
        if (releasedLevelStatic <= releasedLevel)
        {
            releasedLevelStatic = releasedLevel;
        }
        PlayerPrefs.SetInt("Level", releasedLevelStatic);
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(replayLevel);
        if (releasedLevelStatic <= releasedLevel)
        {
            releasedLevelStatic = releasedLevel;
        }
        PlayerPrefs.SetInt("Level", releasedLevelStatic);
    }
}
