
using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	
	public KeyCode forward;
	public KeyCode reverse;
	public KeyCode turnLeft;
	public KeyCode turnRight;
	
	public float acceleration;
	public float turnSpeed = 0.2f;

	bool finished = false;
	bool pauseInput = true;
	
	void  Update (){

		if (pauseInput || finished)
		{
			return;
		}
		else if (Input.GetTouch(0).position.x > Screen.width /2)
		{
			rigidbody2D.AddForce(transform.up * acceleration);
		}
		else if (Input.GetTouch(0).position.x < Screen.width /2)
		{
			rigidbody2D.AddForce(transform.up * -acceleration);
		}
		
		if (Input.acceleration.y > 0)
		{
			rigidbody2D.AddTorque(turnSpeed);
		}
		
		if (Input.acceleration.y < 0)
		{
			rigidbody2D.AddTorque(-turnSpeed);
		}
		
	}
	
	public void ToggleInput()
	{
		Debug.Log("I was Called");
		pauseInput = !pauseInput;
	}

	void Stop()
	{	
		rigidbody2D.velocity = (new Vector2 (0,0));
		rigidbody2D.angularVelocity = 0;

		finished = true;
		Application.LoadLevel("StoryEnd");
	}
}