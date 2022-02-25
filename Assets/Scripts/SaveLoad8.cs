﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad8 : MonoBehaviour
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

        if (PlayerPrefs.HasKey("tresestrelas" + "8"))
        {
            star3.SetActive(true);
            cadeadoProximoLevel.SetActive(false);
            botaoProximoLevel.SetActive(true);
        }

        if (PlayerPrefs.HasKey("duasestrelas" + "8"))
        {

            star2.SetActive(true);
            cadeadoProximoLevel.SetActive(false);
            botaoProximoLevel.SetActive(true);
        }

        if (PlayerPrefs.HasKey("umaestrela" + "8"))
        {
            star1.SetActive(true);
            cadeadoProximoLevel.SetActive(false);
            botaoProximoLevel.SetActive(true);
        }


    }
    // Update is called once per frame


}