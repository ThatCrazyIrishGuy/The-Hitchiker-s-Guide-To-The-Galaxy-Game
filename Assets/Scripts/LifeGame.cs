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
		if(Input.GetKeyDown(KeyCode.R))
		{
			Collider2D[] overlaps = Physics2D.OverlapCircleAll(transform.position, radi);
			Debug.Log(overlaps.Length + gameObject.name);
			if(overlaps.Length < 3 || overlaps.Length > 4)
			{

			}

		}
	}
	
	void setSurrounds()
	{
		surrounds [0] = (Vector2)transform.position + new Vector2 (0, 1);
		surrounds [0] = (Vector2)transform.position + new Vector2 (1, 1);
		surrounds [0] = (Vector2)transform.position + new Vector2 (1, 0);
		surrounds [0] = (Vector2)transform.position + new Vector2 (-1, 1);
		surrounds [0] = (Vector2)transform.position + new Vector2 (-1, 0);
		surrounds [0] = (Vector2)transform.position + new Vector2 (-1, -1);
		surrounds [0] = (Vector2)transform.position + new Vector2 (-1, 0);
		surrounds [0] = (Vector2)transform.position + new Vector2 (1, -1);


	}
}
