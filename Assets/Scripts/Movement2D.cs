using UnityEngine;
using System.Collections;

public class Movement2D : MonoBehaviour {
	
	//Variables
	public float speed = 20.0F;
	public float jumpSpeed = 13.0F;
	public float gravity = 20.0F;
	public KeyCode jump;
	public KeyCode run;
	
	Vector2 moveDirection = Vector2.zero;
	CharacterController controller;
	
	void Start() {
		
		//used to import CharacterController
		controller = GetComponent<CharacterController>();
		
		if(!controller)
			controller = gameObject.AddComponent<CharacterController>();   
		
	}
	
	void Update() {
		
		
		
		// is the controller on the ground?
		if (true) {
			
			
			
			//Feed moveDirection with input.
			moveDirection = new Vector2(Input.GetAxis("Horizontal"), 0);
			moveDirection = transform.TransformDirection(moveDirection);
			//Multiply it by speed.
			moveDirection *= speed;
			
			//Jumping
			if (Input.GetKey(jump)){
				moveDirection.y = jumpSpeed;
			}
			
			if (Input.GetKey(run)){
				speed = 30.0f;
				jumpSpeed = 15.0f;
			}
			else
			{
				speed = 20.0f;
				jumpSpeed = 13.0f;
			}
			
		}

		
		//Applying gravity to the controller
		moveDirection.y -= gravity * Time.deltaTime;
		//Making the character move
		controller.Move(moveDirection * Time.deltaTime);
	}
	
}

