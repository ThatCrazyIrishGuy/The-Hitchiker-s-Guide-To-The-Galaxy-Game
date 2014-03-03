using UnityEngine;
using System.Collections;

public class Birth : MonoBehaviour {

	float timeCounter;
	float growthRate;
	// Use this for initialization
	void Start () 
	{
		timeCounter = 0f;
		growthRate = 32f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			growthRate = growthRate/2;
		}
		timeCounter += Time.deltaTime;
		Debug.Log (timeCounter);
		if(timeCounter > growthRate)
		{

		}
	}
}
