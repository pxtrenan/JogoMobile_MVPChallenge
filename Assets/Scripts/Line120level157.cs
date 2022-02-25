using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line120level157 : MonoBehaviour {

    public GameObject linePrefab;
    public GameObject lineCreator;
    public Image hudContainer;

    public GameObject starYellow1;
    public GameObject starYellow2;
    public GameObject starYellow3;

    public GameObject starGray1;
    public GameObject starGray2;

    public GameObject image3Stars;
    public GameObject image2Stars;
    public GameObject image1Stars;

    public GameObject cestaDePonto1;
    public GameObject cestaDePonto2;
    public GameObject cestaDePonto3;

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

        currentTime -= Time.deltaTime;
        SetHud(currentTime / totalTime);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();

            drawTxt.gameObject.SetActive(false);

        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            image3Stars.gameObject.SetActive(true);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);



            PlayerPrefs.SetInt("tresestrelas", 3);

            cestaDePonto1.gameObject.SetActive(true);

            if (currentTime <= -8.4)
            {
                starYellow1.gameObject.SetActive(false);
                starGray1.gameObject.SetActive(true);
                image3Stars.gameObject.SetActive(false);
                image2Stars.gameObject.SetActive(true);
                PlayerPrefs.SetInt("duasestrelas", 2);
                cestaDePonto1.gameObject.SetActive(false);
                cestaDePonto2.gameObject.SetActive(true);


            }
            if (currentTime <= -16)
            {
                starYellow2.gameObject.SetActive(false);
                starGray2.gameObject.SetActive(true);
                image3Stars.gameObject.SetActive(false);
                image2Stars.gameObject.SetActive(false);
                image1Stars.gameObject.SetActive(true);
                PlayerPrefs.SetInt("umaestrela", 1);
                cestaDePonto1.gameObject.SetActive(false);
                cestaDePonto2.gameObject.SetActive(false);
                cestaDePonto3.gameObject.SetActive(true);

            }
            if (currentTime <= -24)
            {

                activeLine = null;

            }




        }
    }
    public void SetHud(float value)
    {
        float total = 7.2f;
        float pos = total - (value * total);
        hudContainer.transform.localPosition = new Vector3(-pos, hudContainer.transform.localPosition.y, hudContainer.transform.localPosition.z);

    }


}


