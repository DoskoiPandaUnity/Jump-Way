﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCube : MonoBehaviour {


	void Start () {
		Destroy (gameObject, 1f);
	}
	

	void Update () {
		transform.position += new Vector3 (0f, 0.1f, 0f);
	}
}
