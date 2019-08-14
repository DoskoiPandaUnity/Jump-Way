using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

	public GameObject block , allCubes , diam;
	public float speed = 20f;
	private bool stopMov = false;
	private Vector3 target;
	private GameObject blockInst;
	void Start () {
		 target = new Vector3 (Random.Range (0.6f, 2.4f), Random.Range (-3.58f, -0.13f), -3.5f);
		blockInst = Instantiate (block, new Vector3(4.64f , -2.7f, 0f) , Quaternion.identity) as GameObject;
		blockInst.transform.localScale = new Vector3 (SpawnRand(), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
		blockInst.transform.parent = allCubes.transform;
		if (CubeJump.count_blocks % 2 == 0 && CubeJump.count_blocks != 0) {
			GameObject diamond = Instantiate (diam, new Vector3 (4.64f, -2.1f, 0f), Quaternion.Euler (Camera.main.transform.eulerAngles));
			diamond.transform.parent = blockInst.transform;
		}
		}
	void Update(){
		if (blockInst.transform.position != target && !stopMov && !CubeJump.lose)
			blockInst.transform.position = Vector3.MoveTowards (blockInst.transform.position, target, Time.deltaTime * speed);
		else if (blockInst.transform.position == target)
			stopMov = true;
		if (CubeJump.jump && CubeJump.nextBlock && !CubeJump.lose) {
			target = new Vector3 (Random.Range (0.6f, 2.4f), Random.Range (-3.58f, -0.13f), -3.5f);
			blockInst = Instantiate (block, new Vector3(4.64f , -2.7f, 0f) , Quaternion.identity) as GameObject;
			blockInst.transform.localScale = new Vector3 (SpawnRand(), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
			blockInst.transform.parent = allCubes.transform;
			if (CubeJump.count_blocks % 2 == 0) {
				GameObject diamond = Instantiate (diam, new Vector3 (4.64f, -2.1f, 0f), Quaternion.Euler (Camera.main.transform.eulerAngles));
				diamond.transform.parent = blockInst.transform;
			}
			stopMov = false;
		}
	}
	float SpawnRand(){
		float rand;
		if (Random.Range (0, 100) < 80)
			rand = Random.Range (2.2f, 3f);
		else
			rand = Random.Range (2.2f, 3.5f);
		return rand;
	}

}
