using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNowCube : MonoBehaviour {
	public GameObject which , maincube;
	void OnMouseDown(){
	maincube.GetComponent<Renderer> ().material = GameObject.Find (which.GetComponent<SelectCube> ().nowCube).GetComponent<Renderer> ().material;
		PlayerPrefs.SetString ("NowCube", which.GetComponent<SelectCube> ().nowCube);
	}
}
