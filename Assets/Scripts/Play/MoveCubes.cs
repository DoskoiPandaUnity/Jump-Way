using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour {
	private bool moved = true;
	private Vector3 target;
	void Start(){
		target = new Vector3 (-4.72f, 3.01f, -3.049184f);
		
}
	void Update(){
		if (CubeJump.nextBlock) {
			if (transform.position != target && !CubeJump.lose) {
				transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * 5f);
			} else if (transform.position == target && !moved && !CubeJump.lose) {
				target = new Vector3 (transform.position.x - 4.0f, transform.position.y + 3.4f, transform.position.z);
				CubeJump.jump = false;
				moved = true;
			}
		
			if (CubeJump.jump)
				moved = false;
		}
	}
}

		
