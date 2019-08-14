
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartToPlay : MonoBehaviour {
	public Light light;
	public GameObject[] cubes;
	public GameObject blocks , spawn_Blocks , diamond , music;
	public GameObject mainCube , lastcube;
	public Text tapToPlay , gameName , study , record;
	private bool clicked = false;
	public GameObject buttons;
	void Update(){
		if (clicked && light.intensity != 0) {
			light.intensity -= 0.01f;
		}

	}
	void OnMouseDown(){
		if (!clicked) {
			StartCoroutine (DeleteCubes ());
			StartCoroutine (LastCube ());
			clicked = true;
			tapToPlay.gameObject.SetActive (false);
			gameName.text = "0";
			buttons.GetComponent<ScrollObjects> ().target = -100f;
			buttons.GetComponent<ScrollObjects> ().speed = -2f;
			study.gameObject.SetActive (true);
			mainCube.GetComponent<Animation> ().Play ("CubeStart");
			mainCube.transform.localScale = new Vector3 (1f, 1f, 1f);
			blocks.GetComponent<Animation> ().Play ();
			record.gameObject.SetActive (true);
			diamond.gameObject.SetActive (true);
		} else if (clicked && study.gameObject.activeSelf)
			study.gameObject.SetActive (false);
		if (music.gameObject.activeSelf) {
			for (int i = 0; i < music.transform.parent.transform.childCount; i++)
				music.transform.parent.transform.GetChild (i).gameObject.SetActive(!music.transform.parent.transform.gameObject.activeSelf);
		}
	}
	IEnumerator DeleteCubes(){
		for (int i = 0; i < cubes.Length; i++) {
			yield return new WaitForSeconds (0.5f);
			cubes[i].GetComponent<FallCube>().enabled = true;
		}
		spawn_Blocks.GetComponent<SpawnBlocks> ().enabled = true;
	}
	IEnumerator LastCube(){
		yield return new WaitForSeconds (1.3f);
		lastcube.GetComponent<Animation> ().Play ();
		mainCube.AddComponent<Rigidbody>();
	}
}
