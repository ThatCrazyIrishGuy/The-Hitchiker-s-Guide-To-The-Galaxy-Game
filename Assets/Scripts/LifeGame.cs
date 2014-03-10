using UnityEngine;
using System.Collections;

public class LifeGame : MonoBehaviour {
	Vector2[] surrounds;
	float radi;
	void Start () 
	{
		surrounds = new Vector2[8];
		radi = 1f;
		setSurrounds ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.R) && gameObject.tag != "Newborn" && gameObject.name == "CellB")
		{
			Collider2D[] overlaps = Physics2D.OverlapCircleAll(transform.position, radi);
			Debug.Log(overlaps.Length + gameObject.name);
			if(overlaps.Length < 3 || overlaps.Length > 4)
			{
				gameObject.tag = "Destroy";
			}
			for(int i = 0; i < surrounds.Length; i++)
			{
				Collider2D[] tempOver = Physics2D.OverlapCircleAll(surrounds[i], 0.4f);
				Debug.Log(surrounds[i].ToString() + " " + tempOver.Length);
				if(tempOver.Length == 0)
				{
					tempOver = Physics2D.OverlapCircleAll(surrounds[i], radi);
					Debug.Log(surrounds[i].ToString() + " " + tempOver.Length);
					if(tempOver.Length == 3)
					{
						GameObject.Instantiate(gameObject,surrounds[i], Quaternion.identity);
						GameObject temp = GameObject.Find("CellB(Clone)");
						temp.collider2D.enabled = false;
						Vector3 pos = temp.transform.position;
						pos.z = 2;
						temp.transform.position = pos;
						temp.name = "Cell";
						temp.tag = "Newborn";

					}
				}
			}
		}
	}
	
	void setSurrounds()
	{
		surrounds [0] = (Vector2)transform.position + new Vector2 (0, 1);
		surrounds [1] = (Vector2)transform.position + new Vector2 (1, 1);
		surrounds [2] = (Vector2)transform.position + new Vector2 (1, 0);
		surrounds [3] = (Vector2)transform.position + new Vector2 (-1, 1);
		surrounds [4] = (Vector2)transform.position + new Vector2 (-1, 0);
		surrounds [5] = (Vector2)transform.position + new Vector2 (-1, -1);
		surrounds [6] = (Vector2)transform.position + new Vector2 (-1, 0);
		surrounds [7] = (Vector2)transform.position + new Vector2 (1, -1);


	}
}
