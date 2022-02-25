using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUnlock : MonoBehaviour
{
    public int Level;

    public Image cadeado;
    public Text texto;

    private string LevelString;
    
    public void LevelSelect(string _level)
    {
        LevelString = _level;
        SceneManager.LoadScene(LevelString);
    }

    private void Start()
    {
        if (ButtonsLevel.releasedLevelStatic >= Level)
        {
            LevelUnlocked();
        }
        else
        {
            LevelLocked();
        }
    }

  

    void LevelLocked()
    {
        
        cadeado.enabled = true;
        texto.enabled = false;
    }

    void LevelUnlocked()
    {

        cadeado.enabled = false;
        texto.enabled = true;
    }

}

