﻿using UnityEngine;
using System.Collections;

public class Despawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		
	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log("trigger");
		if (other.tag.Equals ("FlyingEnemy")) {
			//Debug.Log("despawn");
			Enemy_Dragon script = other.GetComponent<Enemy_Dragon> ();
			script.onDespawn ();
		}
	}


	// Update is called once per frame
	void Update () {

	}

}
