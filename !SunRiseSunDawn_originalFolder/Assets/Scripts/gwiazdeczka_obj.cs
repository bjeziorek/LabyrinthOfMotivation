using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gwiazdeczka_obj : MonoBehaviour {

	bool triggered;
	public GameObject kulka;
	public GameObject gwiazdeczki_mgr_handler;

	public void GwiazdeczkaZaReklame(){
		Kolizja ();
	}

	public void Kolizja(){
		kulka.GetComponent<sphere> ().SphereCol ();
		print ("triggered: " + triggered);
		if (!triggered) {
			triggered = true;
			//transform.Find ("Cube").gameObject.GetComponent<BoxCollider> ().enabled = false;
			//print ("znalezione dziecko: "+transform.Find ("Cube").gameObject);
			gameObject.GetComponent<literka> ().ZTriggeraLiterki ();
			gwiazdeczki_mgr_handler.GetComponent<gwiazdeczki_mgr> ().ColInfo (gameObject);
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider collision){
		Kolizja ();

	}
	// Use this for initialization
	void Start () {
		triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
