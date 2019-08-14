using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDiamonds : MonoBehaviour {

	private Text text;
	void Start () {
		text = GetComponent<Text> ();
		text.text = PlayerPrefs.GetInt ("Diamond").ToString ();
	}

}
