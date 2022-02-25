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

    


    public void Quit()
    {
        Application.Quit();
    }

}


