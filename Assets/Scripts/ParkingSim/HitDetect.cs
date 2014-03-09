using UnityEngine;
using System.Collections;
using Fungus;

public class HitDetect : Room
{
	public Room Max;

	public static float tip = 3.50f;
	public float pay = tip;
	
	void OnGUI()
	{
		GUI.Label (new Rect ((Screen.width/2 + Screen.width/6 + Screen.width/48),Screen.height/6,100,100), "Tip $" + pay);
	}
	void  OnCollisionEnter2D (){ 
		Debug.Log("Hit");
		UpdatePay();
	}
	
	void  UpdatePay (){
		pay -= 100;
		Debug.Log("$"+ pay);
	}

	void OnTriggerEnter2D(Collider2D hitInfo){
		//Max.GetComponent<MaxTalk>().Finished();
		Debug.Log ("Finished");
		hitInfo.gameObject.SendMessage ("Stop");
	}

		  
		                  
}