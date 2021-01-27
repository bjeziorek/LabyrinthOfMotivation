using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aforyzmy_mgr : MonoBehaviour {

	//FUNKCJE PUBLICZNE=======================================================

	//public void ZebranoLiterke(char abc, string ktoWywolal)
	//KORZYSTA Z:
	//public void ZebranoLiterke(char abc, string ktoWywolal)
	//JEST UZYWANA PRZEZ:
	//

	//string InicjujTekstAforyzmu (string oryg)
	//KORZYSTA Z:
	//
	//JEST UZYWANA PRZEZ:
	//

	//FUNKCJE LOKALNE=========================================================

	//IEnumerator cooldown()
	//KORZYSTA Z:
	//--brak--
	//JEST UZYWANA PRZEZ:
	//public void ZebranoLiterke(char abc, string ktoWywolal)

	//POZOSTALE FUNKCJE=======================================================
	//Start
	//Update 

	//----------------------------------------------------------------------------------

	//ZMIENNE PUBLIC
	public GameObject[] literki;
	public Text ileLiterekZebrano;
	public GameObject opcje;
	public Text gainedLetter;

	//ZMIENNA NARZEDZI
	GameObject n;

	//ZMIENNE LOKALNE
	int ileLiterekNaIle=0;
	string aforyzm_oryginalny;
	Dictionary<char,bool> zebraneLiterki;



	//----------------------------------------------------------------------------------






	//KTO WYWOLUJE:
	//
	public void ZebranoLiterke(char abc, string ktoWywolal){
		print("zebrano literke: "+abc+" ktoWywolal: "+ktoWywolal);
	//	print("przyklad: "+zebraneLiterki['a']);
		if (zebraneLiterki [abc] == false) {
			zebraneLiterki [abc] = true;
			ileLiterekNaIle++;
			gameObject.transform.parent.GetComponent<Animator> ().SetTrigger ("gainedLetter");//ten skrypt jest podpiety pod obiejt aforyzmy, ktory jest dzieckiem canvas

			//if literek zostalo 5 lub mniej czyli ileLiterekNaIle>=18
			if(ileLiterekNaIle>=18){
			//run cooldown
				StartCoroutine("cooldown");
			}

			gainedLetter.text = abc.ToString();
			gameObject.GetComponent<Text> ().text = InicjujTekstAforyzmu (opcje.GetComponent<optionsManager> ().TekstAforyzmu ());
			ileLiterekZebrano.text = ileLiterekNaIle + "/23";
			if (ktoWywolal == "reklama") {
				gameObject.transform.parent.GetComponent<Animator> ().SetBool ("adsEnabled", false);
			}
		}
	}//ZebranoLiterke


	//KTO WYWOLUJE:
	//
	string InicjujTekstAforyzmu (string oryg){
		string obec = oryg;
		char[] obec_pociete=obec.ToCharArray ();
		obec = "";
		for (int i = 0; i < obec_pociete.Length; i++) {
			if (
				((obec_pociete [i] == 'a' ||obec_pociete [i] == 'A' || obec_pociete [i] == 'ą') && !zebraneLiterki ['a']) ||
				((obec_pociete [i] == 'b'||obec_pociete [i] == 'B') && !zebraneLiterki ['b']) ||
				((obec_pociete [i] == 'c' ||obec_pociete [i] == 'C'|| obec_pociete [i] == 'ć'||obec_pociete [i] == 'Ć') && !zebraneLiterki ['c']) ||
				((obec_pociete [i] == 'd'||obec_pociete [i] == 'D') && !zebraneLiterki ['d']) ||
				((obec_pociete [i] == 'e'||obec_pociete [i] == 'E' || obec_pociete [i] == 'ę') && !zebraneLiterki ['e']) ||
				((obec_pociete [i] == 'f'||obec_pociete [i] == 'F') && !zebraneLiterki ['f']) ||
				((obec_pociete [i] == 'g'||obec_pociete [i] == 'G') && !zebraneLiterki ['g']) ||
				((obec_pociete [i] == 'h'||obec_pociete [i] == 'H') && !zebraneLiterki ['h']) ||
				((obec_pociete [i] == 'i'||obec_pociete [i] == 'I') && !zebraneLiterki ['i']) ||
				((obec_pociete [i] == 'j'||obec_pociete [i] == 'J') && !zebraneLiterki ['j']) ||
				((obec_pociete [i] == 'k'||obec_pociete [i] == 'K') && !zebraneLiterki ['k']) ||
				((obec_pociete [i] == 'l' ||obec_pociete [i] == 'L'|| obec_pociete [i] == 'ł'||obec_pociete [i] == 'Ł') && !zebraneLiterki ['l']) ||
				((obec_pociete [i] == 'm'||obec_pociete [i] == 'M') && !zebraneLiterki ['m']) ||
				((obec_pociete [i] == 'n'||obec_pociete [i] == 'N' || obec_pociete [i] == 'ń') && !zebraneLiterki ['n']) ||
				((obec_pociete [i] == 'o'||obec_pociete [i] == 'O' || obec_pociete [i] == 'ó'||obec_pociete [i] == 'Ó' || obec_pociete [i] == 'ö'||obec_pociete [i] == 'Ö') && !zebraneLiterki ['o']) ||
				((obec_pociete [i] == 'p'||obec_pociete [i] == 'P' || obec_pociete [i] == 'q'||obec_pociete [i] == 'Q') && !zebraneLiterki ['p']) ||
				((obec_pociete [i] == 'r'||obec_pociete [i] == 'R') && !zebraneLiterki ['r']) ||
				((obec_pociete [i] == 's'||obec_pociete [i] == 'S' || obec_pociete [i] == 'ś'||obec_pociete [i] == 'Ś') && !zebraneLiterki ['s']) ||
				((obec_pociete [i] == 't'||obec_pociete [i] == 'T') && !zebraneLiterki ['t']) ||
				((obec_pociete [i] == 'u'||obec_pociete [i] == 'U') && !zebraneLiterki ['u']) ||
				((obec_pociete [i] == 'w'||obec_pociete [i] == 'W' || obec_pociete [i] == 'v'||obec_pociete [i] == 'V') && !zebraneLiterki ['w']) ||
				((obec_pociete [i] == 'y'||obec_pociete [i] == 'Y'|| obec_pociete [i] == 'x'||obec_pociete [i] == 'X') && !zebraneLiterki ['y']) ||
				((obec_pociete [i] == 'z' ||obec_pociete [i] == 'Z'|| obec_pociete [i] == 'ż'||obec_pociete [i] == 'Ż' || obec_pociete [i] == 'ź'||obec_pociete [i] == 'Ź') && !zebraneLiterki ['z'])) {
				obec_pociete [i] = '_';
				obec = obec + obec_pociete [i];
			}else{
				obec = obec + obec_pociete [i];

			}//if
		}//for
		return obec;
	}//InicjujTekstAforyzmu


	//KTO WYWOLUJE:
	//public void ZebranoLiterke(char abc, string ktoWywolal)
	IEnumerator cooldown(){
		yield return new WaitForSeconds (30.0f);
		gameObject.transform.parent.GetComponent<Animator> ().SetBool ("adsEnabled",true);//ten skrypt jest podpiety pod obiejt aforyzmy, ktory jest dzieckiem canvas
	}//ienumerator



	//-----------------------------------------------------------------------------------
	//START
	//UPDATE

	void Start () {

		print ("Start");
		zebraneLiterki=new Dictionary<char,bool>();
		zebraneLiterki ['a'] = false;
		zebraneLiterki ['b'] = false;
		zebraneLiterki ['c'] = false;
		zebraneLiterki ['d'] = false;
		zebraneLiterki ['e'] = false;
		zebraneLiterki ['f'] = false;
		zebraneLiterki ['g'] = false;
		zebraneLiterki ['h'] = false;
		zebraneLiterki ['i'] = false;
		zebraneLiterki ['j'] = false;
		zebraneLiterki ['k'] = false;
		zebraneLiterki ['l'] = false;
		zebraneLiterki ['m'] = false;
		zebraneLiterki ['n'] = false;
		zebraneLiterki ['o'] = false;
		zebraneLiterki ['p'] = false;
		zebraneLiterki ['r'] = false;
		zebraneLiterki ['s'] = false;
		zebraneLiterki ['t'] = false;
		zebraneLiterki ['u'] = false;
		zebraneLiterki ['w'] = false;
		zebraneLiterki ['y'] = false;
		zebraneLiterki ['z'] = false;
		print("start przyklad: "+zebraneLiterki ['h']);
		//aforyzm_oryginalny= opcje.GetComponent<optionsManager> ().TekstAforyzmu ();
		//print("tekst aforyzmu: "+aforyzm_oryginalny);
		//gameObject.GetComponent<Text> ().text = InicjujTekstAforyzmu (aforyzm_oryginalny);
	}

	void Update () {
		
	}
}
