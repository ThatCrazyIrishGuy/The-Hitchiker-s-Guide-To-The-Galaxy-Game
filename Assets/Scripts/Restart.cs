using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	Vector3 startPos;
	int fallCount;
	// Use this for initialization
	void Start () 
	{
		startPos = transform.position;
		fallCount = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.y < -10)
		{
			transform.position = startPos;
			fallCount ++;
		}
		if(fallCount > 2)
		{
			Application.LoadLevel("");
			Debug.Log ("You lose");
		}
		if(Vector3.Distance(transform.position, GameObject.Find("Bell").transform.position) < 1)
		{
			Application.LoadLevel("");
			Debug.Log("You win");
		}
	}
}
