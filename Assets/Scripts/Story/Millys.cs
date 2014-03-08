using UnityEngine;
using System.Collections;
using Fungus;

public class Millys : Room
{
	public Room MarvMinding;
	
	void OnEnter() 
	{	
		Say ("I think I may be slightly concused from docking");
		Title ("Ford");
		Say ("You try docking that ship with a duckhunt gun and no fingers");
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
		Say("I'll just use my other.....Um guys");
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
