using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teste : MonoBehaviour
{

    public GameObject linePrefab;
    public GameObject lineCreator;
    public Image hudContainer;


    public GameObject image3Stars;
    public GameObject image2Stars;
    public GameObject image1Stars;

    public GameObject ministars1;
    public GameObject ministars2;
    public GameObject ministars3;

    public GameObject cestaDePonto1;
    public GameObject cestaDePonto2;
    public GameObject cestaDePonto3;

    private float timer = 10f;

    public int estrela;

    public GameObject dotted;
    public GameObject drawTxt;

    Line activeLine;

    private float totalTime = 0.5f;
    private float currentTime;

    private void Start()
    {
        currentTime = totalTime;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentTime -= Time.deltaTime;
            SetHud(currentTime / totalTime);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //cestaDePonto1.gameObject.SetActive(true);

            if (currentTime <= -1.33)
            {
                estrela = 2;

                //image3Stars.gameObject.SetActive(false);
                //image2Stars.gameObject.SetActive(true);
                //ministars3.gameObject.SetActive(false);
                //ministars2.gameObject.SetActive(true);
                //cestaDePonto1.gameObject.SetActive(false);
                //cestaDePonto2.gameObject.SetActive(true);

            }
            if (currentTime <= -3.07)
            {
                estrela = 1;

                //image3Stars.gameObject.SetActive(false);
                //image2Stars.gameObject.SetActive(false);
                //image1Stars.gameObject.SetActive(true);
                //ministars3.gameObject.SetActive(false);
                //ministars2.gameObject.SetActive(false);
                //ministars1.gameObject.SetActive(true);
                //cestaDePonto1.gameObject.SetActive(false);
                //cestaDePonto2.gameObject.SetActive(false);
                //cestaDePonto3.gameObject.SetActive(true);

            }
            if (currentTime <= -4.5)
            {

                activeLine = null;

            }

     
        }
    }
    public void SetHud(float value)
    {
        float total = 35f;
        float pos = total - (value * total);
        hudContainer.transform.localPosition = new Vector3(-pos, hudContainer.transform.localPosition.y, hudContainer.transform.localPosition.z);

    }
}

