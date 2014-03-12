using UnityEngine;
using System.Collections;

public class SpaceSteer : MonoBehaviour {
	float speed;
	float forwardSpeed;
	// Use this for initialization
	void Start () 
	{
		speed = 100f;
		rigidbody2D.velocity = transform.right * -1f * speed * Time.deltaTime;
	}
	
	void Update () {
		Vector3 dir = Vector3.zero;
		
		// we assume that the device is held parallel to the ground
		// and the Home button is in the right hand
		
		// remap the device acceleration axis to game coordinates:
		//  1) XY plane of the device is mapped onto XZ plane
		//  2) rotated 90 degrees around Y axis
		dir.y = -Input.acceleration.y;
		//dir. = Input.acceleration.x;
		
		// clamp acceleration vector to the unit sphere
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		// Make it move 10 meters per second instead of 10 meters per frame...
		dir *= Time.deltaTime;
		
		// Move object
		rigidbody2D.transform.Translate (dir * (speed/4));
	}
	
//	// Update is called once per frame
//	void Update () 
//	{
//		//Up controls
//		if(Input.GetKey(KeyCode.UpArrow))
//		{
//			rigidbody2D.velocity += (Vector2)transform.up * speed * Time.deltaTime;
//		}
//		else if(Input.GetKey(KeyCode.DownArrow))
//		{
//			rigidbody2D.velocity += (Vector2)transform.up * speed * Time.deltaTime * -1f;
//		}
////		else if(Input.GetKey(KeyCode.LeftArrow))
////		{
////			rigidbody2D.velocity += (Vector2)transform.right * speed * Time.deltaTime * -1f;	
////		}
////		else if(Input.GetKey(KeyCode.RightArrow))
////		{
////			rigidbody2D.velocity -= (Vector2)transform.right * speed * Time.deltaTime * -1f;	
////
////		}
//		else
//		{
//			Vector2 temp = rigidbody2D.velocity;
//			//temp =new Vector2(0,0);
//			temp.y = 0;
//			rigidbody2D.velocity = temp;
//		}
//
//	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("col");
		if(other.name == "Cube")
		{	
			Vector3 temp = transform.position;
			if(temp.y > 0)
			{
				temp.y = -6f;
			}
			else
			{
				temp.y = 6f;
			}
			transform.position = temp;


		}

		if(other.name == "Junk")
		{
			Application.LoadLevel("HeartofGoldLife");
			PlayerPrefs.SetInt("BadDocking",1);
		}

		if(other.name == "Dock")
		{
			Application.LoadLevel("Story");
			PlayerPrefs.SetInt("BadDocking",0);
		}
	}
}
