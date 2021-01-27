using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lvlManager : MonoBehaviour {

	//FUNKCJE PUBLICZNE

	//FUNKCJE LOKALNE

	//FUNKCJE POZOSTALE

	public int levelNr;
	public Text levelNrGUIHandler;
	public GameObject menuMgr_Handler;
	public GameObject[] LevelButtons;
	public GameObject[] LevelButtonsKolorowe;
	int world = 1;
	int lastLevel=36;

//	AssetBundle myLoadedAssetBundle;
//	string[] scenePaths;

	IEnumerator czekaj(){
		Pytajniki ();
		yield return new WaitForSeconds (20.0f);
		menuMgr_Handler.GetComponent<menuManager>().SetWorld(world);
	}//czekaj

	void reGreyIcons(){
		if (PlayerPrefs.GetInt ("level7") == 0) {
			LevelButtons [5].SetActive (false);
		} else {
			LevelButtons [5].SetActive (true);
		}
	}


	public void SetWorld(int w){
		world=w;
	//	

		menuMgr_Handler.GetComponent<menuManager>().SetWorld(world);
		Pytajniki ();
	//	StartCoroutine ("czekaj");

	//	print ("LevelButtons [6].activeInHierarchy333 koniec set world: "+LevelButtons [6].activeInHierarchy);
	}

	public int GetWorld(){
		return world;
	}

	public int GetLevelNumber(){
		return levelNr;
	}

	public void Exit(){

		Application.Quit ();

		//System.Environment.Exit(0); <- to mi w androidzie zawiesza cala gre

	}

	public void LoadNextLevel(){
		if (levelNr < lastLevel) {
			SceneManager.LoadScene (levelNr + 1);
			print ("level nr: "+levelNr);
		} else {
			if (levelNr == lastLevel) {
				SceneManager.LoadScene (0);
			} else {
				print ("dziwny blad - levelNr: "+levelNr);
			}
		}
//		SceneManager.LoadScene (scenePaths[levelNr+1], LoadSceneMode.Single);
//		scenePaths = myLoadedAssetBundle.GetAllScenePaths ();
	}

	public void LoadLevelNr(int nr){
		print ("nr: " + nr);
		int i = 0;
		switch(world){
		case 1:
			i = nr;
			print("PlayerPrefs.GetInt('level'+: "+i+" ): "+PlayerPrefs.GetInt ("level" + i)+" world: "+world);
				if (PlayerPrefs.GetInt ("level" + i) == 1) {
					SceneManager.LoadScene (i);
				} else {
					//play sound
				}

			break;
		case 2:
			i = nr + 9;

			print ("PlayerPrefs.GetInt('level'+: " + i+ " ): " + PlayerPrefs.GetInt ("level" + i) + " world: " + world);
			if (PlayerPrefs.GetInt ("level" + i) == 1) {
				SceneManager.LoadScene (i);
			} else {
				//play sound
			}

			break;
		case 3:
			i = nr + 18;
			print ("PlayerPrefs.GetInt('level'+: " + i+ " ): " + PlayerPrefs.GetInt ("level" + i) + " world: " + world);
			print("PlayerPrefs.GetInt('level'+: "+ i+" ): "+PlayerPrefs.GetInt ("level" +  i)+" world: "+world);
			if (PlayerPrefs.GetInt ("level" + i) == 1) {
				SceneManager.LoadScene (i);
			} else {
				//play sound
			}

			break;
		case 4:
			i = nr + 27;
			print ("PlayerPrefs.GetInt('level'+: " + i+ " ): " + PlayerPrefs.GetInt ("level" + i) + " world: " + world);
			print("PlayerPrefs.GetInt('level'+: "+i+" ): "+PlayerPrefs.GetInt ("level" + i)+" world: "+world);
			if (PlayerPrefs.GetInt ("level" + i) == 1) {
				print ("i: " + i);
				SceneManager.LoadScene (i);
			} else {
				//play sound
			}

			break;
		}//switch
	}

	public void LoadMenu(){
		SceneManager.LoadScene (0);
	}

	void Pytajniki(){
		switch (world) {
		case 1:
			LevelButtons [0].SetActive (false);
			LevelButtonsKolorowe [0].SetActive (true);
			if (PlayerPrefs.GetInt ("level2") == 0) {
				LevelButtonsKolorowe [1].SetActive (false);
				LevelButtons [1].SetActive (true);
			} else {
				LevelButtonsKolorowe [1].SetActive (true);
				LevelButtons [1].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level3") == 0) {
				LevelButtonsKolorowe [2].SetActive (false);
				LevelButtons [2].SetActive (true);
			} else {
				LevelButtonsKolorowe [2].SetActive (true);
				LevelButtons [2].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level4") == 0) {
				LevelButtonsKolorowe [3].SetActive (false);
				LevelButtons [3].SetActive (true);
			} else {
				LevelButtonsKolorowe [3].SetActive (true);
				LevelButtons [3].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level5") == 0) {
				LevelButtonsKolorowe [4].SetActive (false);
				LevelButtons [4].SetActive (true);
			} else {
				LevelButtonsKolorowe [4].SetActive (true);
				LevelButtons [4].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level6") == 0) {
				LevelButtonsKolorowe [5].SetActive (false);
				LevelButtons [5].SetActive (true);
			} else {
				LevelButtonsKolorowe [5].SetActive (true);
				LevelButtons [5].SetActive (false);
			}
		
			if (PlayerPrefs.GetInt ("level7") == 0) {
				LevelButtonsKolorowe [6].SetActive (false);
				LevelButtons [6].SetActive (true);
			} else {
				LevelButtonsKolorowe [6].SetActive (true);
				LevelButtons [6].SetActive (false);
			}


		/*	print ("level7: " + PlayerPrefs.GetInt ("level7"));
			if (PlayerPrefs.GetInt ("level7") == 0) {
				print ("in if true");
				LevelButtonsKolorowe [6].SetActive (false);
				LevelButtons [6].SetActive (true);
			} else {
				print ("in if false");
				LevelButtonsKolorowe [6].SetActive (true);
				LevelButtons [6].SetActive (false);
			}
			print ("LevelButtons [6].activeInHierarchy: "+LevelButtons [6].activeInHierarchy);
*/

			if (PlayerPrefs.GetInt ("level8") == 0) {
				LevelButtonsKolorowe [7].SetActive (false);
				LevelButtons [7].SetActive (true);
			} else {
				LevelButtonsKolorowe [7].SetActive (true);
				LevelButtons [7].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level9") == 0) {
				LevelButtonsKolorowe [8].SetActive (false);
				LevelButtons [8].SetActive (true);
			} else {
				LevelButtonsKolorowe [8].SetActive (true);
				LevelButtons [8].SetActive (false);
			}
			break;
		case 2:
			if (PlayerPrefs.GetInt ("level10") == 0) {
				LevelButtonsKolorowe [0].SetActive (false);
				LevelButtons [0].SetActive (true);
			} else {
				LevelButtonsKolorowe [0].SetActive (true);
				LevelButtons [0].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level11") == 0) {
				LevelButtonsKolorowe [1].SetActive (false);
				LevelButtons [1].SetActive (true);
			} else {
				LevelButtonsKolorowe [1].SetActive (true);
				LevelButtons [1].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level12") == 0) {
				LevelButtonsKolorowe [2].SetActive (false);
				LevelButtons [2].SetActive (true);
			} else {
				LevelButtonsKolorowe [2].SetActive (true);
				LevelButtons [2].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level13") == 0) {
				LevelButtonsKolorowe [3].SetActive (false);
				LevelButtons [3].SetActive (true);
			} else {
				LevelButtonsKolorowe [3].SetActive (true);
				LevelButtons [3].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level14") == 0) {
				LevelButtonsKolorowe [4].SetActive (false);
				LevelButtons [4].SetActive (true);
			} else {
				LevelButtonsKolorowe [4].SetActive (true);
				LevelButtons [4].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level15") == 0) {
				LevelButtonsKolorowe [5].SetActive (false);
				LevelButtons [5].SetActive (true);
			} else {
				LevelButtonsKolorowe [5].SetActive (true);
				LevelButtons [5].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level16") == 0) {
				LevelButtonsKolorowe [6].SetActive (false);
				LevelButtons [6].SetActive (true);
			} else {
				LevelButtonsKolorowe [6].SetActive (true);
				LevelButtons [6].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level17") == 0) {
				LevelButtonsKolorowe [7].SetActive (false);
				LevelButtons [7].SetActive (true);
			} else {
				LevelButtonsKolorowe [7].SetActive (true);
				LevelButtons [7].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level18") == 0) {
				LevelButtonsKolorowe [8].SetActive (false);
				LevelButtons [8].SetActive (true);
			} else {
				LevelButtonsKolorowe [8].SetActive (true);
				LevelButtons [8].SetActive (false);
			}
			break;
		case 3:

			if (PlayerPrefs.GetInt ("level19") == 0) {
				LevelButtonsKolorowe [0].SetActive (false);
				LevelButtons [0].SetActive (true);
			} else {
				LevelButtonsKolorowe [0].SetActive (true);
				LevelButtons [0].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level20") == 0) {
				LevelButtonsKolorowe [1].SetActive (false);
				LevelButtons [1].SetActive (true);
			} else {
				LevelButtonsKolorowe [1].SetActive (true);
				LevelButtons [1].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level21") == 0) {
				LevelButtonsKolorowe [2].SetActive (false);
				LevelButtons [2].SetActive (true);
			} else {
				LevelButtonsKolorowe [2].SetActive (true);
				LevelButtons [2].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level22") == 0) {
				LevelButtonsKolorowe [3].SetActive (false);
				LevelButtons [3].SetActive (true);
			} else {
				LevelButtonsKolorowe [3].SetActive (true);
				LevelButtons [3].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level23") == 0) {
				LevelButtonsKolorowe [4].SetActive (false);
				LevelButtons [4].SetActive (true);
			} else {
				LevelButtonsKolorowe [4].SetActive (true);
				LevelButtons [4].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level24") == 0) {
				LevelButtonsKolorowe [5].SetActive (false);
				LevelButtons [5].SetActive (true);
			} else {
				LevelButtonsKolorowe [5].SetActive (true);
				LevelButtons [5].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level25") == 0) {
				LevelButtonsKolorowe [6].SetActive (false);
				LevelButtons [6].SetActive (true);
			} else {
				LevelButtonsKolorowe [6].SetActive (true);
				LevelButtons [6].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level26") == 0) {
				LevelButtonsKolorowe [7].SetActive (false);
				LevelButtons [7].SetActive (true);
			} else {
				LevelButtonsKolorowe [7].SetActive (true);
				LevelButtons [7].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level27") == 0) {
				LevelButtonsKolorowe [8].SetActive (false);
				LevelButtons [8].SetActive (true);
			} else {
				LevelButtonsKolorowe [8].SetActive (true);
				LevelButtons [8].SetActive (false);
			}
			break;
		case 4:

			if (PlayerPrefs.GetInt ("level28") == 0) {
				LevelButtonsKolorowe [0].SetActive (false);
				LevelButtons [0].SetActive (true);
			} else {
				LevelButtonsKolorowe [0].SetActive (true);
				LevelButtons [0].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level29") == 0) {
				LevelButtonsKolorowe [1].SetActive (false);
				LevelButtons [1].SetActive (true);
			} else {
				LevelButtonsKolorowe [1].SetActive (true);
				LevelButtons [1].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level30") == 0) {
				LevelButtonsKolorowe [2].SetActive (false);
				LevelButtons [2].SetActive (true);
			} else {
				LevelButtonsKolorowe [2].SetActive (true);
				LevelButtons [2].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level31") == 0) {
				LevelButtonsKolorowe [3].SetActive (false);
				LevelButtons [3].SetActive (true);
			} else {
				LevelButtonsKolorowe [3].SetActive (true);
				LevelButtons [3].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level32") == 0) {
				LevelButtonsKolorowe [4].SetActive (false);
				LevelButtons [4].SetActive (true);
			} else {
				LevelButtonsKolorowe [4].SetActive (true);
				LevelButtons [4].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level33") == 0) {
				LevelButtonsKolorowe [5].SetActive (false);
				LevelButtons [5].SetActive (true);
			} else {
				LevelButtonsKolorowe [5].SetActive (true);
				LevelButtons [5].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level34") == 0) {
				LevelButtonsKolorowe [6].SetActive (false);
				LevelButtons [6].SetActive (true);
			} else {
				LevelButtonsKolorowe [6].SetActive (true);
				LevelButtons [6].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level35") == 0) {
				LevelButtonsKolorowe [7].SetActive (false);
				LevelButtons [7].SetActive (true);
			} else {
				LevelButtonsKolorowe [7].SetActive (true);
				LevelButtons [7].SetActive (false);
			}
			if (PlayerPrefs.GetInt ("level36") == 0) {
				LevelButtonsKolorowe [8].SetActive (false);
				LevelButtons [8].SetActive (true);
			} else {
				LevelButtonsKolorowe [8].SetActive (true);
				LevelButtons [8].SetActive (false);
			}
			break;
		}//switch
	//	print ("LevelButtons [6].activeInHierarchy22: "+LevelButtons [6].activeInHierarchy);
	}//pytajniki

	// Use this for initialization
	void Start () {
		/*
		if (GetLevelNumber () > 0) {
			levelNrGUIHandler.text = "level: " + GetLevelNumber ().ToString ();
		} else {
			if (GetLevelNumber () == 0) {
				//foreach (GameObject g in LevelButtons) {


				Pytajniki ();

				//}
			} else {
				print ("dziwny blad");
			
			}//if



			//	myLoadedAssetBundle = AssetBundle.LoadFromFile ("Assets/Levels");
		}//drugi if
		*/
	}//start



		public Text fpsText;
		public float deltaTime;

		void Update () {
	//	print ("LevelButtons [6].activeInHierarchy update: "+LevelButtons [6].activeInHierarchy);
	//	print ("LevelButtons [3].activeInHierarchy update2: "+LevelButtons [3].activeInHierarchy);
		/*
			deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
			float fps = 1.0f / deltaTime;
			fpsText.text = Mathf.Ceil (fps).ToString ();
			*/
		}


}