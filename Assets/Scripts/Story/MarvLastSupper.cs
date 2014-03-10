using UnityEngine;
using System.Collections;
using Fungus;

public class MarvLastSupper : Room
{
	public Room BadEnding;
	public Room GoodEnding;
	
	void OnEnter() 
	{	
		Title ("Max");
		Say ("Marvin has cost us so much in damages here that he almost totally bankrupt us");
		Title ("");
		Say ("...");
		Title ("Max");
		Say ("Unfortunately the only way to pay our debts is to sell him on to a ....questionable new owner");
		Title ("Trillian");
		Say ("You can't do that, he is ours");
		Title ("Max");
		Say ("He has been in our custody so long now he is our property now");
		Say ("I'm sorry but its the only way we can pay the damages he has incured");
		Title ("Zaphod");
		Say ("We'll pay the damages");
		Title ("Max");
		Say ("With what, a malfunctioning space ship? that thing wouldn't cover a year");
		Say ("You can say your goodbyes now");
		
		//PlayerPrefs.SetInt("GotPOVGun",1);
		int ending = PlayerPrefs.GetInt("GotPOVGun");
		
		if (ending == 1)
		{
			Title ("Ford");
			Say ("Quick Zaph, pass Marvin the POV gun");
			Title ("Zaphod");
			Say ("Marvin, quick, shoot him...");
			MoveToRoom(GoodEnding);
		}
		else
		{
			Title ("Ford");
			Say ("If only we had the POV gun, maybe we could have changed his mind");
			Title ("");
			Say ("We're so sorry Marvin, we had no idea this was going to happen");
			Title ("Trillian");
			Say ("We'll miss you *sob*");
			Title ("Marvin");
			Say ("It's okay, what can be worse than 5376000 million years of parking cars...");
			MoveToRoom(BadEnding);
		}
	}
}