﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	// Use this for initialization
//	void Start () {
		
		//rb.AddForce(0, 200, 500);
		//rb.useGravity = false;
		//Debug.Log("Aye is dabrina");
//	}
	
	// Update is called once per frame
	//FixedUpdate function name best when using physics (addForce)
	void FixedUpdate () {

		//forward moving force for Player
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d")){
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(Input.GetKey("a")){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
		}

		if(rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
