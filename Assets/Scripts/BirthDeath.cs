using UnityEngine;
using System.Collections;

public class BirthDeath : MonoBehaviour {
	public Vector2[] toDestroy;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.R))
		{
			GameObject[]  temp = GameObject.FindGameObjectsWithTag("Destroy");
			for(int i = temp.Length-1; i > -1; i--)
			{
				GameObject.Destroy(temp[i]);
			}
			temp = GameObject.FindGameObjectsWithTag("Newborn");
			for(int i = temp.Length-1; i > -1; i--)
			{
				temp[i].collider2D.enabled = true;
				Vector3 pos = temp[i].transform.position;
				pos.z = 0;
				temp[i].transform.position = pos;
				temp[i].tag = "Norm";
				temp[i].name = "Cell";
			}


		}
	}
}
