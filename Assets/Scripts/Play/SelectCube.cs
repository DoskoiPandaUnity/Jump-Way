using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCube : MonoBehaviour {
	public GameObject select , buy , maincube;
	public string nowCube;
	public GameObject[] cubes;
	public Vector3 Sience;
	void Start(){

		for (int i = 0; i < cubes.Length; i++) {
			if (PlayerPrefs.GetString ("NowCube") == cubes[i].gameObject.name) {
				maincube.GetComponent<MeshRenderer> ().material.color = cubes[i].GetComponent<MeshRenderer> ().material.color;
				break;
			}
				
		}
		if (PlayerPrefs.GetString ("Cube") != "Open") {
			PlayerPrefs.SetString ("Cube", "Open");
		}
		Sience = cubes [0].transform.localScale;
	}		
	void OnTriggerEnter(Collider other){
		nowCube = other.gameObject.name;
		other.transform.localScale += new Vector3 (0.4f, 0.4f, 0.4f);
		if (PlayerPrefs.GetString (other.gameObject.name) == "Open") {
			select.gameObject.SetActive (true);
			buy.gameObject.SetActive (false);
		} else {
			select.gameObject.SetActive (false);
			buy.gameObject.SetActive (true);
		}
	}
	void OnTriggerExit(Collider other){
		other.transform.localScale -= new Vector3 (0.4f, 0.4f, 0.4f);
	}
}
