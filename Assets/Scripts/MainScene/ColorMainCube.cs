using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMainCube: MonoBehaviour {

	private Color color;
	void Start(){
		color = new Vector4 (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f), color.a);
        GetComponent<Renderer> ().material.color = color;
	}
}
