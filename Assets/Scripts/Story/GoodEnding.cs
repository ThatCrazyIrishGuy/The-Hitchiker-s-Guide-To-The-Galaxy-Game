using UnityEngine;
using System.Collections;
using Fungus;

public class GoodEnding : Room
{
	public Room Credits;
	
	void OnEnter() 
	{	
		Title ("Max");
		Say ("...");
		Say ("How could i have even thought of trading such an intellectual A.I. just to save a business");
		Say ("Marvin, you're free to go");
		Title ("");
		Say ("Huzzah!");
		Title ("Ford");
		Say ("Can you stay open long enough for one last blow-out?");
		Title ("Max");
		Say ("For friends of Marvin, anything...");
		Title ("Narrator");
		Say ("So finally our bunch of unlikely companions settled down for their meal.");
		Say ("The last meal ever to be served at Millyways.");
		Say ("As the Vogons moved their ships into place to destroy what was left of the desolate planet that Milliways was constructed on...");
		Say ("The crew took off to find another adventure, with a new traveling companion...");
		MoveToRoom(Credits);
		
	}
}