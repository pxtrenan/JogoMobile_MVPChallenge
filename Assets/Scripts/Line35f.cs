using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line35f : MonoBehaviour {

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
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();
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

            currentTime -= Time.deltaTime;
            SetHud(currentTime / totalTime);
            if (currentTime <= -1.33)
            {
                starYellow1.gameObject.SetActive(false);
                starGray1.gameObject.SetActive(true);
                image3Stars.gameObject.SetActive(false);
                image2Stars.gameObject.SetActive(true);

            }
            if (currentTime <= -3.07)
            {
                starYellow2.gameObject.SetActive(false);
                starGray2.gameObject.SetActive(true);
                image3Stars.gameObject.SetActive(false);
                image2Stars.gameObject.SetActive(false);
                image1Stars.gameObject.SetActive(true);

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

