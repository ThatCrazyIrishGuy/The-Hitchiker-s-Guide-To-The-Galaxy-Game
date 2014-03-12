using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirthDeath : MonoBehaviour {
	public static List<Vector2> toCreate;
	// Use this for initialization
	void Start () 
	{
		toCreate = new List<Vector2>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(((int)Time.timeSinceLevelLoad % 2) == 1 )
		{
			for(int i = 0; i < toCreate.Count; i++)
			{
				Debug.Log(toCreate[i].ToString());
				Collider2D[] tempOver = Physics2D.OverlapCircleAll(toCreate[i], 0.5f);
				if(tempOver.Length < 1)
				{
					GameObject cell = GameObject.Find("Cell");
					GameObject.Instantiate(cell, toCreate[i], Quaternion.identity);
					GameObject newCell = GameObject.Find("Cell(Clone)");
					newCell.name = "Cell";
					newCell.tag = "Norm";
				}
			}
			GameObject[]  temp = GameObject.FindGameObjectsWithTag("Destroy");
			for(int i = temp.Length-1; i > -1; i--)
			{
				GameObject.Destroy(temp[i]);
			}
			Debug.Log(toCreate.Count);
			toCreate.Clear ();
		}

	}
}
