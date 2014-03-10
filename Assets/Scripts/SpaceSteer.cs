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
	
	// Update is called once per frame
	void Update () 
	{
		//Up controls
		if(Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody2D.velocity += (Vector2)transform.up * speed * Time.deltaTime;
		}
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			rigidbody2D.velocity += (Vector2)transform.up * speed * Time.deltaTime * -1f;
		}
		else
		{
			Vector2 temp = rigidbody2D.velocity;
			temp.y = 0;
			rigidbody2D.velocity = temp;
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("col");
		if(other.name == "Cube")
		{
			Vector2 temp =  rigidbody2D.velocity;
			temp.y = temp.y *-1f;
			rigidbody2D.velocity = temp; 

		}

		if(other.name == "Junk")
		{
			Application.LoadLevel("HeartofGoldLife");
		}

		if(other.name == "Dock")
		{
			Application.LoadLevel("Story");
		}
	}
}
