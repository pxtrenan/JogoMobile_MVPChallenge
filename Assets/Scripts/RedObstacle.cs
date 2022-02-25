using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObstacle : MonoBehaviour {
    
    public GameObject ball;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "RedObstacle")
        {
            ball.gameObject.SetActive(false);
        }
        
    }
}
