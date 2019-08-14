using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsAnimation : MonoBehaviour {
	public SpriteRenderer star;
	public float speed;
	void Start(){
		star = GetComponent<SpriteRenderer>();
		Destroy (gameObject, 5f);
		StartCoroutine (Sience ());
	}
	void Update(){
		star.color = new Color (star.color.r, star.color.g, star.color.b, Mathf.PingPong (Time.time / 2f, 1));
		transform.position += Time.deltaTime * speed * transform.up;
	}
	IEnumerator Sience(){
		for (int i = 1; i < 4; i++) {
			transform.localScale += new Vector3 (0.1f, 0.1f, 0f);
			yield return new WaitForSeconds (0.2f);
		}
	}
}
