
using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	
	public KeyCode forward;
	public KeyCode reverse;
	public KeyCode turnLeft;
	public KeyCode turnRight;
	
	public float acceleration;
	public float turnSpeed;

	bool finished = false;
	bool pauseInput = false;
	
	void  Update (){

		if (pauseInput || finished)
		{
			return;
		}
		if (Input.GetKey(forward))
		{
			rigidbody2D.AddForce(transform.up * acceleration);
		}
		else if (Input.GetKey(reverse))
		{
			rigidbody2D.AddForce(transform.up * -acceleration);
		}
		else
		{
			//rigidbody2D.velocity.y = 0;
		}
		
		if (Input.GetKey(turnLeft))
		{
			rigidbody2D.AddTorque(turnSpeed);
		}
		
		if (Input.GetKey(turnRight))
		{
			rigidbody2D.AddTorque(-turnSpeed);
		}
		
		//rigidbody2D.velocity.x = 0;
		
	}
	
//	public void ToggleInput()
//	{
//		Debug.Log("I was Called");
//		pauseInput = !pauseInput;
//	}

	void Stop()
	{	
		rigidbody2D.velocity = (new Vector2 (0,0));
		rigidbody2D.angularVelocity = 0;

		finished = true;
		Application.LoadLevel("StoryEnd");
	}
}