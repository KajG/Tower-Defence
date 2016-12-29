using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private Vector2 position;
	private Vector2 velocity;
	public float speed;

	void Start () {
		velocity = new Vector2 (speed, 0);
	}
	
	void Update () {
		position = this.transform.position;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			position += velocity;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			position -= velocity;
		}
		this.transform.position = position;
	}
}
