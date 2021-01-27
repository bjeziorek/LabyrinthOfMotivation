using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour {

	//FUNKCJE PUBLICZNE

	//FUNKCJE LOKALNE

	//FUNKCJE POZOSTALE

	GameObject canvasHandler;


	public void ShowTutorial(){
		canvasHandler.GetComponent<Animator> ().SetBool ("tutorial", true);

	}

	public void OkButtonTutorial(){
		canvasHandler.GetComponent<Animator> ().SetBool ("tutorial", false);
		PlayerPrefs.SetInt ("tutorial", 1);
		PlayerPrefs.Save ();
		//zapisz, ze tutorial widziany
		//load 1st level
	}

	// Use this for initialization
	void Start () {
		canvasHandler=transform.parent.gameObject;
		if (PlayerPrefs.GetInt ("tutorial") == 0) {
			ShowTutorial ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
