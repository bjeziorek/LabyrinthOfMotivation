using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas_elem_positioner : MonoBehaviour {

	//FUNKCJE PUBLICZNE===============================================================
	//--brak--

	//FUNKCJE LOKALNE=================================================================

	//float IleProcentX(float x)
	//KORZYSTA Z:
	//--brak--
	//JEST UZYWANA PRZEZ:
	//Start()

	//float IleProcentY(float y)
	//KORZYSTA Z:
	//--brak--
	//JEST UZYWANA PRZEZ:
	//Start()

	//POZOSTALE FUNKCJE================================================================

	//Start
	//KORZYSTA Z:
	//float IleProcentX(float x)
	//float IleProcentY(float y)

	//Update 

	GameObject HomeButtonHandler;
	GameObject lvlNumberHandler;
	GameObject ScoreTextHandler;
	GameObject aforyzmHandler;
	GameObject ileLiterekZebranoHandler;
	GameObject SoundButtonHandler;
	GameObject AdsButtonHandler;

	float HomeButtonHandlerX=0.15f;
	float HomeButtonHandlerY=0.06f;
	float lvlNumberHandlerX=0.35f;
	float lvlNumberHandlerY=0.175f;
	float ScoreTextHandlerX=0.35f;
	float ScoreTextHandlerY=0.215f;
	float aforyzmHandlerX=0.5f;
	float aforyzmHandlerY=0.9f;
	float ileLiterekZebranoHandlerX=0.6f;
	float ileLiterekZebranoHandlerY=0.1f;
	float SoundButtonHandlerX=0.35f;
	float SoundButtonHandlerY=0.06f;
	float AdsButtonHandlerX=0.15f;
	float AdsButtonHandlerY=0.2f;

	float IleProcentX(float x){

		return gameObject.GetComponent<RectTransform> ().rect.width * x * gameObject.GetComponent<RectTransform> ().localScale.x;
	}

	float IleProcentY(float y){

		return gameObject.GetComponent<RectTransform> ().rect.height * y * gameObject.GetComponent<RectTransform> ().localScale.y;
	}

	void Start () {
		
		HomeButtonHandler=transform.Find ("HomeButton").gameObject;
		lvlNumberHandler=transform.Find ("lvlNumber").gameObject;
		ScoreTextHandler=transform.Find ("ScoreText").gameObject;
		aforyzmHandler=transform.Find ("aforyzm").gameObject;
	//	ileLiterekZebranoHandler=transform.Find ("ScoreText").gameObject;
		SoundButtonHandler=transform.Find ("SoundButton").gameObject;
		AdsButtonHandler=transform.Find ("AdsButton").gameObject;

		transform.Find ("aforyzm").gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (400, 200);

		SoundButtonHandler.GetComponent<RectTransform> ().sizeDelta = new Vector2 (130, 130);//  .rect  = new Rect (0,0,130,130); 
	
		HomeButtonHandler.GetComponent<RectTransform> ().sizeDelta = new Vector2 (130, 130);

		AdsButtonHandler.GetComponent<RectTransform> ().sizeDelta = new Vector2 (130, 130);
	
		ScoreTextHandler.GetComponent<RectTransform>().sizeDelta = new Vector2 (130, 130);

	
		HomeButtonHandler.GetComponent<RectTransform> ().position = new Vector3 (IleProcentX(HomeButtonHandlerX),IleProcentY(HomeButtonHandlerY),0);
		lvlNumberHandler.GetComponent<RectTransform>().position = new Vector3 (IleProcentX(lvlNumberHandlerX),IleProcentY(lvlNumberHandlerY),0);
		ScoreTextHandler.GetComponent<RectTransform>().position = new Vector3 (IleProcentX(ScoreTextHandlerX),IleProcentY(ScoreTextHandlerY),0);
		aforyzmHandler.GetComponent<RectTransform>().position = new Vector3 (IleProcentX(aforyzmHandlerX),IleProcentY(aforyzmHandlerY),0);
	//	ileLiterekZebranoHandler.GetComponent<RectTransform>().position = new Vector3 (IleProcentX(ileLiterekZebranoHandlerX),IleProcentY(ileLiterekZebranoHandlerY),0);
		SoundButtonHandler.GetComponent<RectTransform>().position = new Vector3 (IleProcentX(SoundButtonHandlerX),IleProcentY(SoundButtonHandlerY),0);
		AdsButtonHandler.GetComponent<RectTransform>().position = new Vector3 (IleProcentX(AdsButtonHandlerX),IleProcentY(AdsButtonHandlerY),0);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
