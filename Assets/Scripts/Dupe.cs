using UnityEngine;
using System.Collections;

public class Dupe : MonoBehaviour 
{
	public float scalingUpperBound;
	public float scalingLowerBound;
	bool textView;
	int counter;
	Vector3 NewPos;
	GameObject son;
	SpriteRenderer spriteRend;
	// Use this for initialization
	void Start () 
	{
		counter = 0;
		textView = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!(GameObject.Find("Marv").collider2D.isTrigger && GameObject.Find("Art").collider2D.isTrigger && GameObject.Find("Ford").collider2D.isTrigger && GameObject.Find("Trillian").collider2D.isTrigger && GameObject.Find("Zarphod").collider2D.isTrigger))
		{
			textView = true;
		}
		if(textView)
		{
			if(Input.GetKeyDown(KeyCode.Return))
			{
				Application.LoadLevel("Story");
			}
		}


	}
	void OnTriggerEnter2D()
	{
		rigidbody2D.velocity = rigidbody2D.velocity * -1;
		if (rigidbody2D.velocity.y < 0.2f) 
		{
			collider2D.isTrigger = false;
		}
		if(gameObject.name != "clone")
		{
			counter++;
			NewPos = new Vector3 (Random.Range (-10f, 10f), Random.Range (3f, 100f), 0f);
			GameObject.Instantiate (gameObject, NewPos, Quaternion.identity);
			GameObject temp = GameObject.Find (gameObject.name + "(Clone)");
			temp.name = "clone";
			NewPos = new Vector3 (Random.Range (-10f, 10f), Random.Range (10f, 20f), 0f);
			GameObject.Instantiate (gameObject, NewPos, Quaternion.identity);
			temp = GameObject.Find (gameObject.name + "(Clone)");
			temp.name = "clone";
			float scaling = Random.Range(scalingLowerBound, scalingUpperBound);
			Vector2 scaler = new Vector2(scaling,scaling);
			temp.transform.localScale = scaler;
	
		}

	}
}
