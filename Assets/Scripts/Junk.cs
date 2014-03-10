using UnityEngine;
using System.Collections;

public class Junk : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject Heart = GameObject.Find ("HeartOfGold");
		Debug.Log (Heart.transform.position.x);
		Debug.Log (transform.position.x);
		if(gameObject.name == "Junk")
		{
			if(transform.position.x > Heart.transform.position.x)
			{
				int shipX = (int)Heart.transform.position.x;
				float xtemp = (float)Random.Range(shipX-20, shipX-10);
				float ytemp = (float)Random.Range(-7, 7);
				Vector3 temp = new Vector3(xtemp,ytemp);
				GameObject.Instantiate(gameObject,temp,Quaternion.identity);
				GameObject cloner = GameObject.Find("Junk(Clone)");
				cloner.name = "Junk";
				GameObject.Instantiate(gameObject,temp,Quaternion.identity);
				cloner = GameObject.Find("Junk(Clone)");
				cloner.name = "Junk";
				gameObject.name = "dis";

			}
		}
	}
}
