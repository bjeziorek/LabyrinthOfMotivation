using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn7 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("level7") == 0) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
		print ("active: "+
			PlayerPrefs.GetInt ("level1")+
			PlayerPrefs.GetInt ("level2")+
			PlayerPrefs.GetInt ("level3")+
			PlayerPrefs.GetInt ("level4")+
			PlayerPrefs.GetInt ("level5")+
			PlayerPrefs.GetInt ("level6")+
			PlayerPrefs.GetInt ("level7")+
			PlayerPrefs.GetInt ("level8")+
			PlayerPrefs.GetInt ("level9"));
	}
}
