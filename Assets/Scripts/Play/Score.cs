﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

	public Text txt , record;
	private bool gameStart;
	void Start () {
		record.text = "Top:" + PlayerPrefs.GetInt ("Record");
		txt = GetComponent<Text>();	
		CubeJump.count_blocks = 0;
	}
	

	void Update () {
		if (txt.text == "0") {
			gameStart = true;
		}
		if (gameStart) {
			txt.text = CubeJump.count_blocks.ToString();
			if (PlayerPrefs.GetInt ("Record") < CubeJump.count_blocks) {
				PlayerPrefs.SetInt ("Record", CubeJump.count_blocks);
				record.text ="Top:" +  PlayerPrefs.GetInt ("Record");
			}
		}
	}
}
