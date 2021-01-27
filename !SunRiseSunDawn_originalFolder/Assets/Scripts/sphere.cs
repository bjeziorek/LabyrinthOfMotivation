using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

	Color tempColor;

	public void SphereCol(){
		gameObject.GetComponent<Renderer> ().material.color = tempColor;// new Color (200,200,0,0);//Random.ColorHSV();
	}

	void OnTriggerEnter(Collider collision){
	//	print ("trigger");

		//SphereCol ();
	}

	// Use this for initialization
	void Start () {
		tempColor = gameObject.GetComponent<Renderer> ().material.color;
		gameObject.GetComponent<Renderer> ().material.color = new Color (0,0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
