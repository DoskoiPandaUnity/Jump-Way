using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harder : MonoBehaviour {
	private bool hard;
	public GameObject deleteClicks;
	void Update () {
		if (CubeJump.count_blocks > 0) {
			if (CubeJump.count_blocks % 7 == 0 && !hard) {
				hard = true;
				Debug.Log ("Harder");
				Camera.main.GetComponent<Animation> ().Play ("Harder");
				deleteClicks.transform.position = new Vector3 (5.3f, 7.25f, -6.69f);
				deleteClicks.transform.eulerAngles = new Vector3 (31.31f, -64.15f, 0f);
			} else if ((CubeJump.count_blocks % 7) - 1 == 0 && hard) {
				hard = false;
				Debug.Log ("Eaiser");
				Camera.main.GetComponent<Animation> ().Play ("Eaiser");
				deleteClicks.transform.position = new Vector3 (0f, 0f, -6.15f);
				deleteClicks.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
			}
		}
			
	}
}
