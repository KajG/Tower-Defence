using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekTarget : MonoBehaviour {

	public GameObject cross;
	private bool shooting;
	public bool getShooting {get {return shooting;} set{shooting = value;}}
	private Vector2 otherPos;
	public Vector2 getOtherPos {get { return otherPos;} set{otherPos = value;}}
	private SpriteRenderer _rn;

	void Start () {
		_rn = cross.GetComponent<SpriteRenderer> ();
		_rn.enabled = false;
	}
	
	void Update () {
		
	}

	void OnCollisionStay2D(Collision2D other){
		otherPos = other.gameObject.transform.position;
		if (other.gameObject.tag == "Balloon") {
			shooting = true;
			_rn.enabled = true;
			cross.transform.position = otherPos;
		}
	}
	void OnCollisionExit2D(Collision2D other){
		shooting = false;
		_rn.enabled = false;
	}
}
