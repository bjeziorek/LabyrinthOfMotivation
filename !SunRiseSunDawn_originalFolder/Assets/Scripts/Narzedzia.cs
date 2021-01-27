using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narzedzia : MonoBehaviour {//TODO

	//jak uzywac:
	//w kazdym skrypcie dodac zmienne lokalna GameObject n, a w Starcie za zainicjowac n=gameObject.trasform.Find("Narzedzia");

	public void Test(){
		MyPrint ("test print");
	}

	public void EnablePrint(bool b,int mode){
		//jak 0 to wszystkie on, jak -1 to wszystkie off

		//sprawdz czy mode istnieje, jak nie to dodaj i przypisz mu wartosc
	}

	public void MyPrint(string co){
		print (co);
	}

	// Use this for initialization
	void Start () {
		MyPrint ("woked up");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
