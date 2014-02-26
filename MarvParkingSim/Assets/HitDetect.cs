using UnityEngine;
using System.Collections;

public class HitDetect : MonoBehaviour
{
	

	public static float tip = 3.50f;
	public float pay = tip;
	
	void  OnCollisionEnter2D (){ 
		Debug.Log("Hit");
		UpdatePay();
	}
	
	void  UpdatePay (){
		pay -= 100;
		Debug.Log("$"+ pay);
	}
}