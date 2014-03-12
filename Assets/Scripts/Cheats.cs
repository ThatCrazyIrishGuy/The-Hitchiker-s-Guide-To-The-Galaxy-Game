using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.LeftShift))
		{
			if(Input.GetKey(KeyCode.Alpha1))
			{
				Application.LoadLevel("Landing");
			}
			if(Input.GetKey(KeyCode.Alpha2))
			{
				Application.LoadLevel("Sidescroller");
			}
			if(Input.GetKey(KeyCode.Alpha3))
			{
				Application.LoadLevel("lvl1");
			}
		}
	
	}
}
