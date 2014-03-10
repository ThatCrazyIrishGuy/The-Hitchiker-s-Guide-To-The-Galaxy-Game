using UnityEngine;
using System.Collections;
using Fungus;

public class BadEnding : Room
{
	public Room Credits;
	
	void OnEnter() 
	{	 
		Wait(5);
		MoveToRoom(Credits);
	}
		
}