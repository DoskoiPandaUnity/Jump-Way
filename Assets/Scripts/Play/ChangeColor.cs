using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
	private bool cntr =true;
	private Color color;
	void OnCollisionEnter(Collision other){

		color = other.gameObject.GetComponent<Renderer>().material.color;
		if (other.gameObject.tag == "Cube") 
			other.gameObject.GetComponent<MeshRenderer> ().material.color = GetComponent<MeshRenderer> ().material.color;


	}

}