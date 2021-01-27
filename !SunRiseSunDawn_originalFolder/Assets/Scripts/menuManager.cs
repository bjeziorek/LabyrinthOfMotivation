using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {

	//FUNKCJE PUBLICZNE

	//FUNKCJE LOKALNE

	//FUNKCJE POZOSTALE

	public GameObject canvasHandler;
	public GameObject lvlMgr_Handler;

	public Sprite lvl01;
	public Sprite lvl02;
	public Sprite lvl03;
	public Sprite lvl04;
	public Sprite lvl05;
	public Sprite lvl06;
	public Sprite lvl07;
	public Sprite lvl08;
	public Sprite lvl09;
	public Sprite lvl10;
	public Sprite lvl11;
	public Sprite lvl12;
	public Sprite lvl13;
	public Sprite lvl14;
	public Sprite lvl15;
	public Sprite lvl16;
	public Sprite lvl17;
	public Sprite lvl18;
	public Sprite lvl19;
	public Sprite lvl20;
	public Sprite lvl21;
	public Sprite lvl22;
	public Sprite lvl23;
	public Sprite lvl24;
	public Sprite lvl25;
	public Sprite lvl26;
	public Sprite lvl27;
	public Sprite lvl28;
	public Sprite lvl29;
	public Sprite lvl30;
	public Sprite lvl31;
	public Sprite lvl32;
	public Sprite lvl33;
	public Sprite lvl34;
	public Sprite lvl35;
	public Sprite lvl36;
//	public Sprite pytajnik;

	public GameObject ikona1;
	public GameObject ikona2;
	public GameObject ikona3;
	public GameObject ikona4;
	public GameObject ikona5;
	public GameObject ikona6;
	public GameObject ikona7;
	public GameObject ikona8;
	public GameObject ikona9;


	Animator ani;

	public void SetWorld(int w){
		presetIcons (w);
	}



	public void presetIcons(int w){
		switch (w) {
		case 1:
			ikona1.GetComponent<Image> ().sprite = lvl01;
			ikona2.GetComponent<Image> ().sprite = lvl02;
			ikona3.GetComponent<Image> ().sprite = lvl03;
			ikona4.GetComponent<Image> ().sprite = lvl04;
			ikona5.GetComponent<Image> ().sprite = lvl05;
			ikona6.GetComponent<Image> ().sprite = lvl06;
			ikona7.GetComponent<Image> ().sprite = lvl07;
			ikona8.GetComponent<Image> ().sprite = lvl08;
			ikona9.GetComponent<Image> ().sprite = lvl09;
			break;
		case 2:
			ikona1.GetComponent<Image> ().sprite = lvl10;
			ikona2.GetComponent<Image> ().sprite = lvl11;
			ikona3.GetComponent<Image> ().sprite = lvl12;
			ikona4.GetComponent<Image> ().sprite = lvl13;
			ikona5.GetComponent<Image> ().sprite = lvl14;
			ikona6.GetComponent<Image> ().sprite = lvl15;
			ikona7.GetComponent<Image> ().sprite = lvl16;
			ikona8.GetComponent<Image> ().sprite = lvl17;
			ikona9.GetComponent<Image> ().sprite = lvl18;
			break;
		case 3:
			ikona1.GetComponent<Image> ().sprite = lvl19;
			ikona2.GetComponent<Image> ().sprite = lvl20;
			ikona3.GetComponent<Image> ().sprite = lvl21;
			ikona4.GetComponent<Image> ().sprite = lvl22;
			ikona5.GetComponent<Image> ().sprite = lvl23;
			ikona6.GetComponent<Image> ().sprite = lvl24;
			ikona7.GetComponent<Image> ().sprite = lvl25;
			ikona8.GetComponent<Image> ().sprite = lvl26;
			ikona9.GetComponent<Image> ().sprite = lvl27;
			break;
		case 4:
			ikona1.GetComponent<Image> ().sprite = lvl28;
			ikona2.GetComponent<Image> ().sprite = lvl29;
			ikona3.GetComponent<Image> ().sprite = lvl30;
			ikona4.GetComponent<Image> ().sprite = lvl31;
			ikona5.GetComponent<Image> ().sprite = lvl32;
			ikona6.GetComponent<Image> ().sprite = lvl33;
			ikona7.GetComponent<Image> ().sprite = lvl34;
			ikona8.GetComponent<Image> ().sprite = lvl35;
			ikona9.GetComponent<Image> ().sprite = lvl36;
			break;
		default:
			print ("blad");
			break;
		}//switch
	}

	public void runQuotesState(){

		ani.SetInteger ("menu_ani",99);

	}

	public void ChangeAnimationState(int nrAnimacji){
		ani.SetInteger ("menu_ani",nrAnimacji);
	}

	// Use this for initialization
	void Start () {
		ani = canvasHandler.GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
