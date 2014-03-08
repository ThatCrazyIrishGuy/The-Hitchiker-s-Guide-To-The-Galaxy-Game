using UnityEngine;
using System.Collections;
using Fungus;

public class Temple : Room
{
	public Room HummaChallenge;
	
	void OnEnter() 
	{	
		Title ("Trillian");
		Say ("This place is totally dead");
		Title ("");
		Say ("The last time we we're here it was full");
		Title ("Ford");
		Say ("Maybe we just missed a Sermon");
		Title ("");
		Say ("Shoudln't their still be one or two Jatravartids praying?");
		Title ("Zaphod");
		Say ("HUMMA, GET YOUR SPIDNLY ASS OUT HERE");
		MoveToRoom(HummaChallenge);
	}
	
}