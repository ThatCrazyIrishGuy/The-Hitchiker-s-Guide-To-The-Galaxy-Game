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
		if(gameObject.name != "clone")
		{
			counter++;
			NewPos = new Vector3 (Random.Range (-10f, 10f), Random.Range (3f, 100f), 0f);
			GameObject.Instantiate (gameObject, NewPos, Quaternion.identity);
			GameObject temp = GameObject.Find (gameObject.name + "(Clone)");
			temp.name = "clone";
			NewPos = new Vector3 (Random.Range (-10f, 10f), Random.Range (3f, 100f), 0f);
			GameObject.Instantiate (gameObject, NewPos, Quaternion.identity);
			temp = GameObject.Find (gameObject.name + "(Clone)");
			temp.name = "clone";
			float scaling = Random.Range(0.2f, 0.9f);
			Vector2 scaler = new Vector2(scaling,scaling);
			temp.transform.localScale = scaler;
			//spriteRend = temp.GetComponent<SpriteRenderer>();
			//Sprite[] sprites = Resources.LoadAll<Sprite>("Assets/Fungus/Sprites");
			//Debug.Log(sprites.Length);
			//spriteRend.sprite = sprites[(int)Random.Range(0, sprites.Length)];
	
		}

	}
}
