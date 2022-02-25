using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public GameObject playLevelButton;
    public GameObject replayLevelButton;
    public GameObject ballSprite;
    public GameObject ballTrue;
    public GameObject lineCreator;
    public GameObject homeButton;
    public GameObject playGameButton;
    public GameObject moreGamesButton;
    public GameObject canvasMoreGames;
    public GameObject voltar1;
    public GameObject menuzinho;


    public string ANDROID_OTHER1_URL = "https://play.google.com/store/apps/details?id=com.ra.HorizonHill";
    public string ANDROID_OTHER2_URL = "https://play.google.com/store/apps/details?id=com.ra.StarScraper";
    public string ANDROID_OTHER3_URL = "https://play.google.com/store/apps/details?id=com.ra.MVPChallenge";

    Line activeLine;


    public void PlayLevelButton()
    {
        ballSprite.gameObject.SetActive(false);
        ballTrue.gameObject.SetActive(true);
        lineCreator.gameObject.SetActive(false);
        activeLine = null;
    }

    public void ReplayLvlButton(string nomeLevel)
    {
        SceneManager.LoadScene(nomeLevel);
    }
    public void HomeButton(string nomeLevel)
    {
        SceneManager.LoadScene(nomeLevel);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("1");
    }
    public void MoreGames()
    {
       
        canvasMoreGames.gameObject.SetActive(true);
    }
    public void Voltar1()
    {
        
        canvasMoreGames.gameObject.SetActive(false);
    }

    public void NxtLevel(string nomeLevel)
    {
        SceneManager.LoadScene(nomeLevel);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Levels");
    }

    public void PressedButtonOther1()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER1_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther2()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER2_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther3()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER3_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }


    public void Quit()
    {
        Application.Quit();
    }

}


