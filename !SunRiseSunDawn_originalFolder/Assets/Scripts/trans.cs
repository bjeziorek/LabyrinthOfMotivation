using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans : MonoBehaviour {

	//FUNKCJE PUBLICZNE

	//FUNKCJE LOKALNE

	//FUNKCJE POZOSTALE

	public string keyword; //dla sound i cytatow bedzie np SoundLevel, a nie SoundOnLevel, dla cytatow cytat, a nie np cytat3

	public string GetKeyword(){
		return keyword;
	}

	public void UpdateKeyword(string key){
		keyword = key;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
