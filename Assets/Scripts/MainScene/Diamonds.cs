using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Diamonds : MonoBehaviour {
	public Text countDiam;
	void Start(){
		countDiam.text = PlayerPrefs.GetInt ("Diamonds").ToString ();

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Diamond") {
			Destroy (other.gameObject);
			PlayerPrefs.SetInt ("Diamonds", PlayerPrefs.GetInt ("Diamonds") + 1);
			countDiam.text = PlayerPrefs.GetInt ("Diamonds").ToString ();
		}
	}
}
