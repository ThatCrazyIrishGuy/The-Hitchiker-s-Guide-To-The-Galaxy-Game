using UnityEngine;
using System.Collections;
using Fungus;

public class Millys : Room
{
	public Room MarvMinding;
	
	void OnEnter() 
	{	if (PlayerPrefs.GetInt("BadDocking") == 0)
		{
			Say ("I think I may be slightly concused from docking");
			Title ("Ford");
			Say ("You try docking that ship with a duckhunt gun and no fingers");
			Say ("At least i didn't hit anything");
		}
		else
		{
			Say ("What the hell just happened?");
			Title ("Ford");
			Say (" That collision hit the ship's IID");
			Say ("If the energy conduit wasn't burned out that could have been the end");
		}

		Say ("We really need to fix Eddie");
		Title ("Eddie");
		Say ("I am Error");
		Title ("");
		Say ("Great, now he's quoting Zelda");
		Say ("...");
		Title ("Zaphod");
		Say ("This sucks, I can't even see the Milky Way from here");
		Title ("Ford");
		Say ("It's right there!");
		Say ("Just turn your head");
		Title ("Zaphod");
		Say("I'll just use my other.....ummm guys");
		Title ("");
		Say ("What now?");
		Title ("Zaphod");
		Say	("I'M STILL MISSING MY OTHER HEAD!");
		Say ("We gotta go get it back, I think the POV gun is still wedged in the magazine rack");
		Title ("");
		Say ("Can we at least eat first?");
		Title ("Zaphod");
		Say	("No, we will only be like 30 minutes tops");
		Title ("Ford");
		Say ("Marvin did you fix the Improbable Infinity Drive");
		Title ("Marvin");
		Say ("I'm fine in case you we're wondering...");
		Say ("Without a new conduit I can't be sure of anything");
		Say ("I've calculated the chance of it working correctly, but I don't think you'll like it. ");
		Title ("Zaphod");
		Say	("Fantastic, lets go");
		Say ("Marvin, you hold the tables");
		Title ("Trillian");
		Say ("We'll be right back");
		MoveToRoom(MarvMinding);
	}
	
}
