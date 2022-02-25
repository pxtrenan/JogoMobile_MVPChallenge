using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line80f : MonoBehaviour
{

    public GameObject linePrefab;
    public GameObject lineCreator;
    public Image hudContainer;

    public GameObject starYellow1;
    public GameObject starYellow2;
    public GameObject starYellow3;

    public GameObject image3Stars;
    public GameObject image2Stars;
    public GameObject image1Stars;

    public GameObject grayStar1;
    public GameObject grayStar2;

    public GameObject cestaDePonto1;
    public GameObject cestaDePonto2;
    public GameObject cestaDePonto3;

    private int estrela;

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
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            estrela = 3;
            image3Stars.gameObject.SetActive(true);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);

            drawTxt.gameObject.SetActive(false);

            cestaDePonto1.gameObject.SetActive(true);

            if (currentTime <= -9.7)
        {
            estrela = 2;

            starYellow1.gameObject.SetActive(false);
            image3Stars.gameObject.SetActive(false);
            image2Stars.gameObject.SetActive(true);
            grayStar1.gameObject.SetActive(true);
            cestaDePonto1.gameObject.SetActive(false);
            cestaDePonto2.gameObject.SetActive(true);

        }
        if (currentTime <= -17.9)
        {
            estrela = 1;
            starYellow2.gameObject.SetActive(false);
            image3Stars.gameObject.SetActive(false);
            image2Stars.gameObject.SetActive(false);
            image1Stars.gameObject.SetActive(true);
            grayStar2.gameObject.SetActive(true);
            cestaDePonto1.gameObject.SetActive(false);
            cestaDePonto2.gameObject.SetActive(false);
            cestaDePonto3.gameObject.SetActive(true);

        }
        if (currentTime <= -26.6)
        {

            activeLine = null;

        }

       

           
        }
    }
    public void SetHud(float value)
    {
        float total = 6.5f;
        float pos = total - (value * total);
        hudContainer.transform.localPosition = new Vector3(-pos, hudContainer.transform.localPosition.y, hudContainer.transform.localPosition.z);

    }
}

