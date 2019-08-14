using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCube : MonoBehaviour {
	public GameObject which , selectImage , maincube;
	void OnMouseDown(){
		if (PlayerPrefs.GetInt ("Diamonds") >= 10) { // buy diamond
			PlayerPrefs.SetString (which.GetComponent<SelectCube> ().nowCube, "Open");
			PlayerPrefs.SetString ("NowCube", which.GetComponent<SelectCube> ().nowCube);

			selectImage.gameObject.SetActive (true);
			gameObject.SetActive (false);
			maincube.GetComponent<Renderer> ().material = GameObject.Find (which.GetComponent<SelectCube> ().nowCube).GetComponent<Renderer> ().material;
		}
}
}
