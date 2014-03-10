using UnityEngine;
using System.Collections;

public class LifeGame : MonoBehaviour {
	static public bool started;
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
		if(Time.timeSinceLevelLoad > 20)
		{
			Application.LoadLevel("Story");
		}
		if(((int)Time.timeSinceLevelLoad % 3) == 0)
		{


			for(int i = 0; i < surrounds.Length; i++)
			{
				Collider2D[] tempOver = Physics2D.OverlapCircleAll(surrounds[i], 0.4f);
				
				if(tempOver.Length == 0)
				{
					tempOver = Physics2D.OverlapCircleAll(surrounds[i], radi);
					
					if(tempOver.Length == 3)
					{
						BirthDeath.toCreate.Add(surrounds[i]);
					}
				}
			}
			Collider2D[] overlaps = Physics2D.OverlapCircleAll(transform.position, radi);
			if(overlaps.Length < 3 || overlaps.Length > 4)
			{
				gameObject.tag = "Destroy";
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
