using UnityEngine;
using System.Collections;
using Fungus;

public class IIDStrangness : Room
{
	public Room Temple;
	
	void OnEnter() 
	{	
		Title ("Ford");
		Say ("Ouch, it's never been that rough before, but I think it's worked!");
		Title ("");
		Say ("I am so sick of being knocked around this ship, when can we get it properly repaired?");
		Title ("Zaphod");
		Say ("After we get my head back and eat, i know a guy");
		Title ("Trillian");
		Say ("Can we go ahead and dock so we can get this over with");
		Title ("Zaphod");
		Say ("Like I havn't heard that one before...");
		Title ("Ford");
		Say("Okay, let me just hook Eddie back up and we'll be down faster than Marvin's psyche");
		MoveToRoom(Temple);
	}
	
}