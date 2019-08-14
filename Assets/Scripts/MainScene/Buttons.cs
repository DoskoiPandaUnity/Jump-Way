using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour {
	public GameObject shopBG;
	public Text record;
	void Start(){
		if (gameObject.name == "Settings") {
				if (PlayerPrefs.GetString ("Music") == "off") {
					transform.GetChild(1).gameObject.GetComponent<Image> ().sprite = mus_off;
					Camera.main.GetComponent<AudioListener> ().enabled = false;

			}
		}
	}
	public Sprite mus_on , mus_off;
	public float bigger = 0.7f , lower = 0.6f;
	void OnMouseDown(){
		transform.localScale = new Vector3 (bigger , bigger , bigger);
	}
	void OnMouseUp(){
		transform.localScale = new Vector3 (lower , lower , lower);
	}
	void OnMouseUpAsButton(){
		switch(gameObject.name){
		case"Restart":
			GetComponent<AudioSource> ().Play ();
			SceneManager.LoadScene ("Title Game");
			break;
		case "Facebook":
			GetComponent<AudioSource> ().Play ();
			Application.OpenURL("https://vk.com/id228582187");
			break;
		case "Music":
			GetComponent<AudioSource> ().Play ();
			if (PlayerPrefs.GetString ("Music") == "off") {
				GetComponent<Image>().sprite = mus_on;
				PlayerPrefs.SetString ("Music", "on");
				Camera.main.GetComponent<AudioListener> ().enabled = true;
			} else {
				GetComponent<Image> ().sprite = mus_off;
				PlayerPrefs.SetString ("Music", "off");
				Camera.main.GetComponent<AudioListener> ().enabled = false;
			}
			break;
		case "Settings":
			GetComponent<AudioSource> ().Play ();
			for (int i = 0; i < transform.childCount; i++)
				transform.GetChild (i).gameObject.SetActive (!transform.GetChild (i).gameObject.activeSelf);
			break;
		case "Shop":
			GetComponent<AudioSource> ().Play ();
			shopBG.gameObject.SetActive (!shopBG.activeSelf);
			break;
		case "Close":
			GetComponent<AudioSource> ().Play ();
			shopBG.gameObject.SetActive (false);
			break;
		}

	}
}
