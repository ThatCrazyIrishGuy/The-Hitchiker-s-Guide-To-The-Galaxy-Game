using UnityEngine;
using System.Collections;

public class Movement3D : MonoBehaviour {
	float speed;
	Vector3 left;
	Vector3 right;
	Vector3 up;
	Vector3 down;
	// Use this for initialization
	void Start () 
	{
		speed = 100f;
		left = new Vector3 (0, -0.4f, 0);
		right = new Vector3 (0, 0.4f, 0);
		down = new Vector3 (0.4f, 0, 0);
		up = new Vector3 (-0.4f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Shoot
		if(Input.GetMouseButtonDown(0))
		{
			GameObject.Instantiate(GameObject.Find("Bullet"));

		}
		//Movements
		if(Input.GetKey(KeyCode.W))
		{
			rigidbody.velocity = (transform.forward * Time.deltaTime * speed);
		}
		else if(Input.GetKey(KeyCode.S))
		{
			rigidbody.velocity = (transform.forward * Time.deltaTime * speed * -1f);
		}
		else if(Input.GetKey(KeyCode.A))
		{
			rigidbody.velocity = (transform.right * Time.deltaTime * speed * -1f);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			rigidbody.velocity = (transform.right * Time.deltaTime * speed * -1f);
		}
		else
		{
			rigidbody.velocity = Vector3.zero;
		}

		//Look direction
		if(Input.mousePosition.x < ((Screen.width/10) * 4))
		{
			Debug.Log("left");
			transform.Rotate(left);
		}
		if(Input.mousePosition.x > (Screen.width-(Screen.width/10) * 4))
		{
			Debug.Log("right");
			transform.Rotate(right);
		}
		if(Input.mousePosition.y < ((Screen.height/10) * 4))
		{
			Debug.Log("down");
			transform.Rotate(down);
		}
		if(Input.mousePosition.y > (Screen.height-(Screen.height/10) * 4))
		{
			Debug.Log("up");
			transform.Rotate(up);
		}
	}
}
