﻿using UnityEngine;
using System.Collections;

public class TestProjectile : MonoBehaviour {

	Vector3 spawnPosition;
	Vector3 direction;
	float speed;
	float damage;

	//wird ausgeführt, wenn eine Instanz geladen wird
	void Awake(){
		speed = 20.0f;
	}

	// Use this for initialization
	void Start () {
		damage = 8f;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "FlyingEnemy"){
			Destroy (gameObject);

			other.gameObject.SendMessage ("dealDamage", damage, SendMessageOptions.RequireReceiver);
			//coll.gameObject.SendMessage("ApplyDamage", 10);
		}

	}

	public void setup(Vector3 spawnPosition, Vector3 direction){
		this.direction = direction.normalized;
		transform.position = spawnPosition;
		this.spawnPosition = spawnPosition;
		transform.rotation = Quaternion.identity;
		//rotation entsprechend richtungsvektor
	}

	// Update is called once per frame
	void Update () {

		if(Vector3.Distance(transform.position, spawnPosition) > 20f){
			Destroy (gameObject);
		}

		//obj.transform.Translate (direction*Time.deltaTime, Space.World);
		transform.Translate (direction*speed*Time.deltaTime, Space.World);	
	}
}