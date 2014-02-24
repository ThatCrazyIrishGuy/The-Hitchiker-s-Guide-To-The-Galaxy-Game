using UnityEngine;
using System.Collections;
using Fungus;

public class TheJohn : Room
{
	public Room TheBridge;
	public Room viewRoom;

	void OnEnter()
	{

		// Sets the title text on the page
		Title("");
		
		// Each Say() command writes one line of text, followed by a continue button
		Say ("This has made a lot of people very angry and been widely regarded as a bad move.");
		MoveToRoom(TheBridge);
	}

}
