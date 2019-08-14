using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColors : MonoBehaviour {


	void Start () {
		GetComponent<Renderer> ().material.color = new Vector4 (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f), 1);
	}
	

}
