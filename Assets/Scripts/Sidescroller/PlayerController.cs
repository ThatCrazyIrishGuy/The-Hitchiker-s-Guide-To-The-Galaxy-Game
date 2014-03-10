using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerPhysics))]
public class PlayerController : MonoBehaviour {
	
	// Player Handling
	public float gravity = 20;
	public float speed = 2;
	public float acceleration = 30;
	public float jumpHeight = 12;
	public Vector3 dimShift = new Vector3(0,0,-1);

	private float currentSpeed;
	private float targetSpeed;
	private Vector2 amountToMove;
	
	private bool jumped= false;
	private bool disableInput = false;
	private float momentum = 0f;
	
	private PlayerPhysics playerPhysics;
	

	void Start () {
		playerPhysics = GetComponent<PlayerPhysics>();
	}
	
	void Update () {
		// Reset acceleration upon collision
		if (playerPhysics.movementStopped) {
			targetSpeed = 0;
			currentSpeed = 0;
		}
		
		// If player is touching the ground
		if (playerPhysics.grounded) {
			amountToMove.y = 0;
			jumped = false;
			disableInput = false;
		}
		else
		{
			disableInput = true;
		}
			
		// Jump
		for (var i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch(i).phase == TouchPhase.Began && !jumped) {
				amountToMove.y = jumpHeight;
				jumped= true;
			}
		}

		//Change angle
//		if(Input.GetKeyDown(KeyCode.E))
//		{
//			GameObject cur = GameObject.Find("Cube");
//			cur.transform.Rotate(dimShift);
//		}

		if (disableInput)
		{
			targetSpeed = momentum;	
		}
		else if (Input.acceleration.x > 0.05)
		{
			targetSpeed = Input.acceleration.z * speed;
		}
		else if(Input.acceleration.x < -0.05)
		{
			targetSpeed = (-Input.acceleration.z) * speed;
		}
		else
		{
			targetSpeed = 0;
		}
		momentum = targetSpeed;
		currentSpeed = IncrementTowards(currentSpeed, targetSpeed,acceleration);
		
		// Set amount to move
		amountToMove.x = currentSpeed;
		amountToMove.y -= gravity * Time.deltaTime;
		playerPhysics.Move(amountToMove * Time.deltaTime);
	}
	
	// Increase n towards target by speed
	private float IncrementTowards(float n, float target, float a) {
		if (n == target) {
			return n;	
		}
		else {
			float dir = Mathf.Sign(target - n); // must n be increased or decreased to get closer to target
			n += a * Time.deltaTime * dir;
			return (dir == Mathf.Sign(target-n))? n: target; // if n has now passed target then return target, otherwise return n
		}
	}
}
