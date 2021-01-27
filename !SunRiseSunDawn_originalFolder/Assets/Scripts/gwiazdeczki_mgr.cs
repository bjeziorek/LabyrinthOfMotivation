using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Advertisements;

public class gwiazdeczki_mgr : MonoBehaviour {

	//FUNKCJE PUBLICZNE
	//public int GetGwiazdkiZebraneIle()
	//public int GetGwiazdkiZebraneIle()
	//public void AdsWatchButton()
	//public void AdsNoThanksButton()
	//public void BackToMenuYesButton()
	//public void BackToMenuNoButton()
	//public void ShowBackToMenuPrompt()
	//public void ShowAdsPrompt()
	//public void UsunGwiazdeczkeZListy()
	//public void ColInfo(GameObject co)

	//FUNKCJE LOKALNE
	//void AdsCallbackHandler(ShowResult result)
	//IEnumerator czekajNaReklameTimeout()

	//POZOSTALE FUNKCJE


	//-----------------------------------------------------------------

	//ZMIENNE PUBLIC====================================================
	public GameObject[] gwiazdeczki;
	public Text GUI_handler;
	public GameObject levelManagerHandler;
	public GameObject canvasHandler;
	public GameObject opcje;
	public int gwiazdkiZebrane=0;
	//public Text testAdsDebug;

	//ZMIENNE LOKALNE==================================================
	int ileGwiazdek=-1;
	bool przerwij;
	bool wyswietlono=false;
	string rezultat="Waiting for connection with ad provider...";

	//------------------------------------------------------------------
	//FUNKCJE PUBLICZNE================================================

	public int GetGwiazdkiZebraneIle(){
		return gwiazdkiZebrane;
	}



	//===================================================================================================================
	public void AdsWatchButton(){
		print ("in ad: "+Advertisement.IsReady ("rewardedVideo"));
		//Advertisement.Show ("rewardedVideo");
	//	testAdsDebug.text="Please wait, loading ads...";
	//	testAdsDebug.text = "in ad: " + Advertisement.IsReady ("rewardedVideo");

		ShowOptions options = new ShowOptions();
		options.resultCallback = AdsCallbackHandler;

		przerwij = false;

	//	StartCoroutine ("czekajNaReklameTimeout");
	//	testAdsDebug.text="Waiting for connection with ad provider...";
		/*
		while (!Advertisement.IsReady ("rewardedVideo")) {
			testAdsDebug.text="Preparing ad...";
			if (przerwij) {
				break;
				przerwij = false;
			}

		}*/

		if (Advertisement.IsReady ("rewardedVideo")) {
			//var options=new ShowOptions{resultCallback=HandleAdResult}
		//	testAdsDebug.text="wyswietlono";
			Advertisement.Show ("rewardedVideo", options);


		} else {
		//	testAdsDebug.text="Brak internetu"; //to sie nie wyswietla
			print ("ad error O_o");
		}

		//warunek


	//	testAdsDebug.text = rezultat; //to sie nie wyswietla

	}//add watch button





	//===================================================================================================================
	public void AdsNoThanksButton(){
		canvasHandler.GetComponent<Animator>().SetBool("adsPrompt",false);
	}
		

	//===================================================================================================================
	public void BackToMenuYesButton(){
		SceneManager.LoadScene (0);

	}

	//===================================================================================================================
	public void BackToMenuNoButton(){
		canvasHandler.GetComponent<Animator>().SetBool("backToMenuPrompt",false);
	}

	//===================================================================================================================
	public void ShowBackToMenuPrompt(){
		canvasHandler.GetComponent<Animator>().SetBool("backToMenuPrompt",true);
	}


	//===================================================================================================================
	public void ShowAdsPrompt(){
		canvasHandler.GetComponent<Animator>().SetBool("adsPrompt",true);
	}

	//===================================================================================================================
	public void UsunGwiazdeczkeZListy(){
		bool znaleziono = false;
		int i = 0;
		while (!znaleziono && i<23) {
			if (gwiazdeczki [i] != null) {
				znaleziono = true;
			//	print (gwiazdeczki [i].GetComponent<literka> ().GetABC());
				GameObject aforyzm=canvasHandler.transform.Find ("aforyzm").gameObject;
				aforyzm.GetComponent<aforyzmy_mgr> ().ZebranoLiterke (gwiazdeczki [i].GetComponent<literka> ().GetABC(),"reklama");
				gwiazdeczki [i].GetComponent<gwiazdeczka_obj> ().GwiazdeczkaZaReklame ();

			} else {
				i++;
			}
		}
		//musze sie dostac do literki-aforyzmymgr-zebranoliterke
		//oraz wyciagnac z literki koknretna literke
	}

	//===================================================================================================================

	public void ColInfo(GameObject co){
		gwiazdkiZebrane++;
		GetComponent<AudioSource> ().Play ();
		GUI_handler.text = opcje.GetComponent<optionsManager>().GetTranslationOf("Letters")+ ": "+gwiazdkiZebrane.ToString () + "/" + ileGwiazdek.ToString();
		if (gwiazdkiZebrane == ileGwiazdek) {
			//wywolaj GUIEndLevel();
			int temp = levelManagerHandler.GetComponent<lvlManager> ().GetLevelNumber () + 1;
			PlayerPrefs.SetInt("quote"+levelManagerHandler.GetComponent<lvlManager> ().GetLevelNumber (),1);
			PlayerPrefs.SetInt("level"+temp,1);

			PlayerPrefs.Save ();

			print ("savy - quote" + levelManagerHandler.GetComponent<lvlManager> ().GetLevelNumber () + ": " + PlayerPrefs.GetInt ("quote" + levelManagerHandler.GetComponent<lvlManager> ().GetLevelNumber ()));
			print ("savy - level" +temp + ": " + PlayerPrefs.GetInt ("level" + levelManagerHandler.GetComponent<lvlManager> ().GetLevelNumber ()));

			canvasHandler.GetComponent<Animator>().SetBool("endLevel",true);
			//tu mozna audio source na koniec levelu
		}
	}

	//===================================================================================================================
	//==========================   LOKALNE    ===========================================================================
	//===================================================================================================================
	void AdsCallbackHandler(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			rezultat="rezultat: ShowResult.Finished";
			UsunGwiazdeczkeZListy ();
			canvasHandler.GetComponent<Animator>().SetBool("adsPrompt",false);
			break;
		case ShowResult.Skipped:
			//dodac error window animation
			rezultat="rezultat: ShowResult.Skipped";
			//	opcje.transform.Find ("AdsPromptText").gameObject.GetComponent<Text> ().text = "Add skipped... :(";
			//	testAdsDebug.text="Add skipped... :(";
			break;
		case ShowResult.Failed:
			rezultat="rezultat: ShowResult.Failed";
			//	opcje.transform.Find ("AdsPromptText").gameObject.GetComponent<Text> ().text = "Brak internetu";
			//	testAdsDebug.text="Brak internetu";
			//dodac error window animation
			break;
		default:
			print ("cos dziwnego sie stalo");
			break;

		}//switch
		//	testAdsDebug.text = rezultat;
	}//AdsCallbackHandler

	//===================================================================================================================
	IEnumerator czekajNaReklameTimeout(){//nie uzywam tego

		yield return new WaitForSeconds (3.0f);

		//	testAdsDebug.text="Nie mozna sie polaczyc...";
		przerwij = true;
	}

	//===================================================================================================================

	// Use this for initialization
	void Start () {

		if(levelManagerHandler.GetComponent<lvlManager> ().GetLevelNumber ()>0){
		ileGwiazdek = gwiazdeczki.Length;
		GUI_handler.text = gwiazdkiZebrane.ToString () + "/" + ileGwiazdek.ToString();
		}
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
