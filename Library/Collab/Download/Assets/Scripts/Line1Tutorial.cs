using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line1Tutorial : MonoBehaviour
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

    public GameObject playButton;
    public GameObject timeButton;

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

        currentTime -= Time.deltaTime;
        SetHud(currentTime / totalTime);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();
            drawTxt.gameObject.SetActive(false);
            dotted.gameObject.SetActive(false);
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


            cestaDePonto1.gameObject.SetActive(true);

            if (currentTime <= -11.5)
            {
            estrela = 2;

            image3Stars.gameObject.SetActive(false);
            image2Stars.gameObject.SetActive(true);
            ministars3.gameObject.SetActive(false);
            ministars2.gameObject.SetActive(true);
            cestaDePonto1.gameObject.SetActive(false);
            cestaDePonto2.gameObject.SetActive(true);

            }
             if (currentTime <= -21.5)
            {
            estrela = 1;

            image3Stars.gameObject.SetActive(false);
            image2Stars.gameObject.SetActive(false);
            image1Stars.gameObject.SetActive(true);
            ministars3.gameObject.SetActive(false);
            ministars2.gameObject.SetActive(false);
            ministars1.gameObject.SetActive(true);
            cestaDePonto1.gameObject.SetActive(false);
            cestaDePonto2.gameObject.SetActive(false);
            cestaDePonto3.gameObject.SetActive(true);

            }
            if (currentTime <= -31.4)
            {

            activeLine = null;

            }

      

        
            
          
        }
    }
    public void SetHud(float value)
    {
        float total = 5.5f;
        float pos = total - (value * total);
        hudContainer.transform.localPosition = new Vector3(-pos, hudContainer.transform.localPosition.y, hudContainer.transform.localPosition.z);

    }

    
}

