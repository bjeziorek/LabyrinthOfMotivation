using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class literka : MonoBehaviour {

	//FUNKCJE PUBLICZNE

	//FUNKCJE LOKALNE

	//FUNKCJE POZOSTALE

	public char abc;

	public char GetABC(){
		print ("get abc: " + abc);
		return abc;
	}

	public void ZTriggeraLiterki(){
		gameObject.GetComponentInParent<literki_grupa> ().GetAforyzmyHandler ().GetComponent<aforyzmy_mgr> ().ZebranoLiterke (GetABC(),"literka");

	}

	void OnTriggerEnter(Collider collision){
	//	print ("gameObject i abc: "+gameObject+" "+abc);
	//	gameObject.GetComponentInParent<literki_grupa> ().GetAforyzmyHandler ().GetComponent<aforyzmy_mgr> ().ZebranoLiterke (abc);
	//	Destroy (gameObject);
	}
}
