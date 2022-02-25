using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad152 : MonoBehaviour
{


    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public bool proximoLevel;
    public GameObject cadeadoProximoLevel;
    public GameObject botaoProximoLevel;


    // Use this for initialization
    void Start()
    {
        // COMANDO PARA REINICIAR TODOS OS SAVES DO JOGO    
       //PlayerPrefs.DeleteAll();

        proximoLevel = false;
        Levels();
    }

    public void Levels()
    {
        proximoLevel = true;

        if (PlayerPrefs.HasKey("tresestrelas" + "152"))
        {
            star3.SetActive(true);
            cadeadoProximoLevel.SetActive(false);
            botaoProximoLevel.SetActive(true);
        }

        if (PlayerPrefs.HasKey("duasestrelas" + "152"))
        {

            star2.SetActive(true);
            cadeadoProximoLevel.SetActive(false);
            botaoProximoLevel.SetActive(true);
        }

        if (PlayerPrefs.HasKey("umaestrela" + "152"))
        {
            star1.SetActive(true);
            cadeadoProximoLevel.SetActive(false);
            botaoProximoLevel.SetActive(true);
        }


    }
    // Update is called once per frame


}
