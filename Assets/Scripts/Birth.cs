using UnityEngine;
using System.Collections;

public class Birth : MonoBehaviour {
	// Use this for initialization
	Vector3[] surrounds;
	void Start () 
	{
		surrounds = new Vector3[26];
		setSurrounds ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.R))
		{

		}
	}

	void setSurrounds()
	{
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 1, 1);
		surrounds [0] = transform.position + new Vector3 (1, 1, 1);
		surrounds [0] = transform.position + new Vector3 (1, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, -1, 1);
		surrounds [0] = transform.position + new Vector3 (-1, -1, 1);
		surrounds [0] = transform.position + new Vector3 (-1, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
		surrounds [0] = transform.position + new Vector3 (0, 0, 1);
	}
}
