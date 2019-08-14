using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBG : MonoBehaviour {
	public GameObject detectC , allBlocks , ScrollObjects , probs;
	public GameObject[] cubes;
	void OnEnable () {
		detectC.GetComponent<BoxCollider> ().enabled = false;
		ScrollObjects.gameObject.SetActive (true);
		allBlocks.gameObject.SetActive (true);
	}
	void OnDisable(){
		detectC.GetComponent<BoxCollider> ().enabled = true;
		allBlocks.gameObject.SetActive (false);
		ScrollObjects.gameObject.SetActive (false);
		for (int i = 0; i < cubes.Length; i++) {
			cubes [i].transform.localScale =probs.GetComponent<SelectCube> ().Sience;
		}
	}

}
