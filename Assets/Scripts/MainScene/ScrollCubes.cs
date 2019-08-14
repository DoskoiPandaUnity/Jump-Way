using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCubes : MonoBehaviour {
	public GameObject cubes;
	private Vector3 screenPoint = new Vector3(0f , -0.83f , 0f) , offset;
	private float yPos;

	void Update () {
		if(cubes.transform.position.x > 3.2f)
			cubes.transform.position = Vector3.MoveTowards(cubes.transform.position,new Vector3(3.2f , cubes.transform.position.y , cubes.transform.position.z) , Time.deltaTime * 30f);
				else if (cubes.transform.transform.position.x < -7.98f)
			cubes.transform.position = Vector3.MoveTowards(cubes.transform.position,new Vector3(-7.98f , cubes.transform.position.y , cubes.transform.position.z) , Time.deltaTime * 30f);								
	}
					void OnMouseDown(){
		yPos = screenPoint.y;
		offset = cubes.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));				
	}
					void OnMouseDrag(){
		Vector3 curPos = offset + Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
						curPos.y = yPos;
						cubes.transform.position = curPos;
					}
					}

