using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public GameObject alavancaOFF;
    public GameObject alavancaON;
    public GameObject alavancaOFFB;
    public GameObject alavancaONB;
    public GameObject alavancaOFF2;
    public GameObject alavancaON2;
    public GameObject alavancaOFFB2;
    public GameObject alavancaONB2;
    public GameObject alavancaOFFBGear;
    public GameObject alavancaONBGear;
    public GameObject alavancaOFFBGear2;
    public GameObject alavancaONBGear2;
    public GameObject alavancaOFFBGear3;
    public GameObject alavancaONBGear3;
    public GameObject alavancaOFF150;
    public GameObject alavancaON150;
    public GameObject setas;
    public GameObject setas2;
    public GameObject setas3;
    public GameObject setas4;
    public GameObject setas5;
    public GameObject gear1;
    public GameObject gear2;
    public GameObject gear3;
    public GameObject gear4;
    public GameObject gear5;
    public GameObject gear6;
    public GameObject gear7;
    public GameObject gear8;
    private Rigidbody2D rb;

    public GameObject barreiraClose;
    public GameObject barreiraOpen;
    public GameObject buttonOpen;
    public GameObject buttonClose;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Trampolim"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(3.2f, 3.2f);
        }

        if (other.gameObject.CompareTag("Trampolim -"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2.2f, 5.5f);
        }

        if (other.gameObject.CompareTag("Trampolim Esquerda"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-3.2f, 3.2f);
        }

        if (other.gameObject.CompareTag("Trampolim PE"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2.2f, 5.5f);
        }

        if (other.gameObject.CompareTag("Trampolim EF"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1.3f, 3.2f);
        }
        if (other.gameObject.CompareTag("Trampolim QF"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2.2f, 3.2f);
        }
        if (other.gameObject.CompareTag("Trampolim PQF"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2.2f, 4.3f);
        }
        if (other.gameObject.CompareTag("Trampolim BEF"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1.8f, 2.6f);
        }

       
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Alavanca OFF"))
        {
            alavancaOFF.gameObject.SetActive(false);
            alavancaON.gameObject.SetActive(true);
            rb.gravityScale = -6/5;
            setas.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Alavanca OFF baixo"))
        {
            alavancaOFFB.gameObject.SetActive(false);
            alavancaONB.gameObject.SetActive(true);
            rb.gravityScale = 1;
            setas2.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Alavanca OFF2"))
        {
            alavancaOFF2.gameObject.SetActive(false);
            alavancaON2.gameObject.SetActive(true);
            rb.gravityScale = -6 / 5;
            setas3.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("Alavanca OFF baixo 2"))
        {
            alavancaOFFB2.gameObject.SetActive(false);
            alavancaONB2.gameObject.SetActive(true);
            rb.gravityScale = 1;
            setas4.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("Alavanca OFF Gear"))
        {
            alavancaOFFBGear.gameObject.SetActive(false);
            alavancaONBGear.gameObject.SetActive(true);
            gear1.gameObject.SetActive(false);
            gear2.gameObject.SetActive(true);
            gear3.gameObject.SetActive(false);
            gear4.gameObject.SetActive(true);
            rb.gravityScale = -1;
            setas5.gameObject.SetActive(true);
        
        }

        
        if (other.gameObject.CompareTag("Alavanca OFF GearB"))
        {
            alavancaOFFBGear2.gameObject.SetActive(false);
            alavancaONBGear2.gameObject.SetActive(true);
            //gear1.gameObject.SetActive(true);
            //gear2.gameObject.SetActive(false);
            //gear3.gameObject.SetActive(true);
            //gear4.gameObject.SetActive(false);
            //gear5.gameObject.SetActive(true);
            //gear6.gameObject.SetActive(false);
            //gear7.gameObject.SetActive(true);
            //gear8.gameObject.SetActive(false);
            rb.gravityScale = 1;
            setas4.gameObject.SetActive(true);

        }

        if (other.gameObject.CompareTag("Alavanca OFF GearC"))
        {
            alavancaOFFBGear.gameObject.SetActive(false);
            alavancaONBGear.gameObject.SetActive(true);
            gear1.gameObject.SetActive(false);
            gear2.gameObject.SetActive(true);
            gear3.gameObject.SetActive(false);
            gear4.gameObject.SetActive(true);
            gear5.gameObject.SetActive(false);
            gear6.gameObject.SetActive(true);
            gear7.gameObject.SetActive(false);
            gear8.gameObject.SetActive(true);
            rb.gravityScale = -1;
            setas5.gameObject.SetActive(true);

        }

        if (other.gameObject.CompareTag("Alavanca OFF GearC2"))
        {
            alavancaOFFBGear3.gameObject.SetActive(false);
            alavancaONBGear3.gameObject.SetActive(true);
            rb.gravityScale = -1;
            setas3.gameObject.SetActive(true);

        }

        if (other.gameObject.CompareTag("AlavancaOFF150"))
        {
            alavancaOFF150.gameObject.SetActive(false);
            alavancaON150.gameObject.SetActive(true);
            gear1.gameObject.SetActive(false);
            gear2.gameObject.SetActive(true);
            gear3.gameObject.SetActive(false);
            gear4.gameObject.SetActive(true);
            rb.gravityScale = 1;
            setas5.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("ButtonClose"))
        {
            buttonClose.gameObject.SetActive(false);
            buttonOpen.gameObject.SetActive(true);
            barreiraClose.gameObject.SetActive(false);
            barreiraOpen.gameObject.SetActive(true);
        }
    }
}
