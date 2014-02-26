using UnityEngine;
using System.Collections;
using Fungus;

public class TheBridge : Room 
{
	// This is a reference to the menu room so we can transition back to the menu using MoveToRoom()
	public Room TheJohn;

	// The OnEnter() method is called whenever the player enters the room
	// You can also use the OnLeave() method to handle when the player leaves the room.
	void OnEnter()
	{
		// Sets the title text on the page
		Title ("");

		// Each Say() command writes one line of text, followed by a continue button
		Say ("In the beginning the Universe was created.");
		MoveToRoom (TheJohn);
	}
}
