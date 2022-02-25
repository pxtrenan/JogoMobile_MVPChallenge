using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGear : MonoBehaviour
{

    public GameObject gear1;


    public float rateSpawn;
    public float currentTime;
    private float y;

    private int number, temp = 0;

    void Start()
    {

        currentTime = 0;
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;
            number = Random.Range(1, 2);

            while (temp == number)
            {
                number = Random.Range(1, 31);
            }

            temp = number;

            Debug.Log(number);
            if (number == 1)
            {
                GameObject tempPrefab = Instantiate(gear1) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }
    }
}
