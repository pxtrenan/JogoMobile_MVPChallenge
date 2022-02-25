using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class Bolinha : MonoBehaviour {

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject cesta2;
    public GameObject lvlPassed;

    public GameObject ministars1;
    public GameObject ministars2;
    public GameObject ministars3;

    public string nomeDoLevelQueEsta;

    public void ShowInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("Intersticial aberto");
        }
    }

    void Start()
    {
        RequestInterstitialAds();
        nomeDoLevelQueEsta = SceneManager.GetActiveScene().name;
        
    }



    InterstitialAd interstitial;
    private void RequestInterstitialAds()
    {
        string adID = "ca-app-pub-3526702404345714/1931791280";

#if UNITY_ANDROID
        string adUnitId = adID;
#elif UNITY_IOS
        string adUnitId = adID;
#else
        string adUnitId = adID;
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //***Test * **
         AdRequest request = new AdRequest.Builder()
        .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
        .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
        .Build();

        //***Production * **
       // AdRequest request = new AdRequest.Builder().Build();

        //Register Ad Close Event
        interstitial.OnAdClosed += Interstitial_OnAdClosed;

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("Intersticial pronto");

    }
    //Ad Close Event
    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        //Resume Play Sound

    }

    
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CestaDePonto")
        {

            ShowInterstitialAd();

            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(true);
            star3.gameObject.SetActive(true);

            Handheld.Vibrate();
            
            lvlPassed.gameObject.SetActive(true);
            PlayerPrefs.SetInt("tresestrelas" + nomeDoLevelQueEsta , 3);
            
        }

       if (other.tag == "2CestaDePonto")
        {
            ShowInterstitialAd();

            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(true);
            star3.gameObject.SetActive(true);

            Handheld.Vibrate();

            lvlPassed.gameObject.SetActive(true);
            PlayerPrefs.SetInt("duasestrelas" + nomeDoLevelQueEsta, 2);
            
        }

        if (other.tag == "3CestaDePonto")
        {
            ShowInterstitialAd();

            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(true);
            star3.gameObject.SetActive(true);

            Handheld.Vibrate();

            lvlPassed.gameObject.SetActive(true);

            PlayerPrefs.SetInt("umaestrela" + nomeDoLevelQueEsta, 1);
            
        }
               

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Trampolim"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 10f);
        }

    }


}
