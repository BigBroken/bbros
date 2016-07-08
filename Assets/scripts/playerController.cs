﻿using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	// Use this for initialization
	//player stats
	public int maxBombs = 1;
	public float speed = 6.0F;
	public int placedBombs = 0;
	public int playerNum = 1;

	//bomb prefab
	public Transform Bomb;

	//private variables
	private Vector3 moveDirection = Vector3.zero;


	void placeBomb () {
		if(placedBombs < maxBombs) {
			placedBombs++;
//			Bomb bombClone = Instantiate(bomb, transform.position, transform.rotation) as Bomb;
//			bombClone.player = 'player1' 
		}
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController> ();
		moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;
		controller.Move (moveDirection * Time.deltaTime);
		if(Input.GetButtonDown("Fire1")) {
			placeBomb();
		}

	}

}
	
