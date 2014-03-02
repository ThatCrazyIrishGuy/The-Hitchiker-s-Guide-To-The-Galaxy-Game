using UnityEngine;
using System.Collections;

public class Dupe : MonoBehaviour 
{
	int counter;
	Vector3 NewPos;
	GameObject son;
	SpriteRenderer spriteRend;
	// Use this for initialization
	void Start () 
	{
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void OnTriggerEnter2D()
	{
		rigidbody2D.velocity = rigidbody2D.velocity * -1;
		if (rigidbody2D.velocity.y < 0.2f) 
		{
			collider2D.isTrigger = false;
		}
		if(gameObject.name == "Marv")
		{
			NewPos = new Vector3 (Random.Range (3f, 10f), Random.Range (3f, 10f), 0f);
			GameObject.Instantiate (gameObject, NewPos, Quaternion.identity);
			GameObject temp = GameObject.Find ("Marv(clone)");
			temp.name = "Sprite" + counter;
			int chooseSprite = (int)Random.Range(0,4);
			spriteRend = temp.GetComponent<SpriteRenderer>();
			Debug.Log(chooseSprite);
			switch(chooseSprite)
			{
				case 0:
				spriteRend.sprite = Resources.Load<Sprite>("Assets\\FallingMarvin\\BigZarphod.PNG");
					break;
				case 1:
				spriteRend.sprite = Resources.Load<Sprite>("Assets/FallingMarvin/BigZarphod");
					//spriteRend.sprite = Resources.Load<Sprite>("MarvBig.png");
					break;
				case 2:
				spriteRend.sprite = Resources.Load<Sprite>("Assets/FallingMarvin/BigZarphod");
					//spriteRend.sprite = Resources.Load<Sprite>("FordBig.png");
					break;
				case 3:
				spriteRend.sprite = Resources.Load<Sprite>("Assets/FallingMarvin/BigZarphod");
					//spriteRend.sprite = Resources.Load<Sprite>("ArtBig.png");
					break;
			}
			//temp.collider2D.isTrigger = false;
		}

	}
}
