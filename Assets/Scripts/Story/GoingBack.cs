using UnityEngine;
using System.Collections;
using Fungus;

public class GoingBack : Room
{
	public Room IIDStrangness;
	
	void OnEnter() 
	{	
		Say ("I don't know why they even hired a Narator if they wern't going to...");
		Say ("After an undocking that could rival a Pan Galactic Gargle Blaster, Ford engaged the IID again and eveyone held tight...");
		MoveToRoom(IIDStrangness);
	}
	
}
