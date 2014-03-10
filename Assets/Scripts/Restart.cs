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
			PlayerPrefs.SetInt("GotHead",0);
			PlayerPrefs.SetInt("GotPOVGun",0);
			Application.LoadLevel("StoryMid");
			//Debug.Log ("You lose");
		}
		if(Vector3.Distance(transform.position, GameObject.Find("Bell").transform.position) < 1)
		{
			PlayerPrefs.SetInt("GotHead",1);
			PlayerPrefs.SetInt("GotPOVGun",1);
			Application.LoadLevel("StoryMid");
			//Debug.Log("You win");
		}
	}
}
