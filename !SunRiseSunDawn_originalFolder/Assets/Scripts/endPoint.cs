using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPoint : MonoBehaviour {



	public GameObject levelManagerHandler;

	public void EndButton(){
		levelManagerHandler.GetComponent<lvlManager> ().LoadNextLevel ();
	}

	void OnTriggerEnter(Collider collision){
		levelManagerHandler.GetComponent<lvlManager> ().LoadNextLevel ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
