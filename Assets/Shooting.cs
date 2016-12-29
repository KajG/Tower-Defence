using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	[SerializeField]
	private SeekTarget Seektarget;
	[SerializeField]
	private GameObject _proj;
	[SerializeField]
	private float projectileSpeed;
	public List<GameObject> _projectileList = new List<GameObject>();
	[SerializeField]
	private int maxProjectiles;
	private Vector2 velocity;
	private Vector2 towerPosition;
	private Vector2 balloonPos;
	private Vector2 projectilePosition;


	void Start () {
		Seektarget = Seektarget.GetComponent<SeekTarget> ();
		projectilePosition = _proj.transform.position;

	}
	
	void Update () {
		balloonPos = Seektarget.getOtherPos;
			if (Seektarget.getShooting) { // Als de shooting true is, dus als hij in zń veld zit.
				print (maxProjectiles);
				Shoot (_projectileList [0]);
		}
	}
	void Shoot(GameObject projectile){
			Instantiate (projectile, towerPosition, Quaternion.identity);
			Vector2 desiredStep = balloonPos - projectilePosition;
			desiredStep.Normalize ();
			projectilePosition += (desiredStep / 100) * projectileSpeed;
			projectile.transform.position = projectilePosition;
			print (balloonPos);
	}
}
