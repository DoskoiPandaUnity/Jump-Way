using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjects : MonoBehaviour {
	public float speed, target = 0f;
	private RectTransform rec;
	void Start () {
		rec = GetComponent<RectTransform>();
	}

	void Update () {
		if (rec.offsetMin.y != target) {
			rec.offsetMin += new Vector2 (rec.offsetMin.x, speed);
			rec.offsetMax += new Vector2 (rec.offsetMax.x, speed);
		}
		}
	}

