using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextFade : MonoBehaviour {
	private Text text ;
	private Outline oline;

	void Start () {
		text = GetComponent<Text> ();
		oline = GetComponent<Outline> ();
	}
	

	void Update () {
		text.color = new Color (text.color.r, text.color.g, text.color.b, Mathf.PingPong (Time.time / 2f, 1f));
		oline.effectColor = new Color (oline.effectColor.r, oline.effectColor.g,oline.effectColor.b , text.color.a - 0.2f);
	}
}
