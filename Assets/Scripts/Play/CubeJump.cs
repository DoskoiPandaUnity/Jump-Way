using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJump : MonoBehaviour {
	public static bool jump, nextBlock, lose; 
	public GameObject maincube , buttons , losebuttons;
	private bool animate;
	private float startTime, yPosCube;
	private float scrath_speed = 0.4f;
	public static int count_blocks = 0;
	void Start(){
		StartCoroutine (CanJump ());
		lose = false;
		jump = false;
	}
	void Update(){
		if (animate && maincube.transform.localScale.y > 0.4f) {
			PressCube (-scrath_speed);
		} else if (!animate && maincube != null) {
			if (maincube.transform.localScale.y < 1f) {
				PressCube (scrath_speed * 3);
			} else if (maincube.transform.localScale.y != 1f)
				maincube.transform.localScale = new Vector3 (1f, 1f, 1f);
		}
		if (maincube != null) {
			if (maincube.transform.position.y < -6.4f) {
				Destroy (maincube);
				Debug.Log ("Player Lose");
				lose = true;
			}
		}
				if (lose)
					PlayerLose ();
		
	
	}
	void PlayerLose(){
		if (!losebuttons.gameObject.activeSelf)
			losebuttons.gameObject.SetActive (true);
		Debug.Log ("Player Lose");
		losebuttons.GetComponent<ScrollObjects>().target = 130f;
		buttons.GetComponent<ScrollObjects> ().target = 50f;
		buttons.GetComponent<ScrollObjects> ().speed = 2;
	}

	void OnMouseDown(){
		if (nextBlock &&  maincube.GetComponent<Rigidbody> ()) {
			yPosCube = maincube.transform.localPosition.y;
			animate = true;
		 startTime = Time.time;
		}

			
	}
	void OnMouseUp(){
		if ( nextBlock && maincube.GetComponent<Rigidbody> () && animate == true) {
			nextBlock = false;
			jump = true;
			animate = false;	
			// Jump
			float force , diff;
			diff = Time.time - startTime;
			if (diff < 2f)
				force = 300f * diff;
			else
				force = 300f;
			if (force < 60f)
				force = 60f;
			maincube.GetComponent<Rigidbody> ().AddRelativeForce (maincube.transform.up * force);
			maincube.GetComponent<Rigidbody> ().AddRelativeForce (maincube.transform.right * -force);
			StartCoroutine (CheckPosCube ());


		}
		}
	void PressCube(float force){
		maincube.transform.localPosition += new Vector3 (0f, force * Time.deltaTime, 0f);
		maincube.transform.localScale += new Vector3 (0f, force * 3 * Time.deltaTime, 0f);
	}
	IEnumerator CheckPosCube(){

		yield return new WaitForSeconds (2f);
		if (yPosCube == maincube.transform.localPosition.y) {
			lose = true;
		}
		else {
			while (!maincube.GetComponent<Rigidbody> ().IsSleeping ()) {
				yield return new WaitForSeconds (0.05f);
				if (maincube == null || yPosCube == maincube.transform.localPosition.y) {
					lose = true;
					break;
				}
			}
			if (!lose) {
				nextBlock = true;
				count_blocks++;
				maincube.transform.localPosition = new Vector3 (-0.4f, maincube.transform.localPosition.y, maincube.transform.localPosition.z);
				maincube.transform.eulerAngles = new Vector3 (0f, maincube.transform.eulerAngles.y, 0f);
			}

		}
	}
	IEnumerator CanJump(){
		while (!maincube.GetComponent<Rigidbody> ())
			yield return new WaitForSeconds (0.05f);
		yield return new WaitForSeconds (1f);
		nextBlock = true;
	}
}