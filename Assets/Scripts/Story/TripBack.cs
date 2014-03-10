using UnityEngine;
using System.Collections;
using Fungus;

public class TripBack : Room
{
	public Room BackAtMillys;
	
	void OnEnter() 
	{	
		Title ("");
		Say ("Finally we're on the way back");
		Say ("I could eat a horse and its foal");
		Title ("Ford");
		Say ("You're in luck");
		Say ("Millies does excellent deep fried horse");
		Title ("");
		Say ("...");
		Title ("Trillian");
		Say ("Forget your stomachs guys...");
		Say ("WE FORGOT ABOUT MARVIN!");
		Title ("Ford");
		Say ("Yeah, its been an hour or two");
		Say ("He's gonna be pretty ticked off");
		Title ("Zaphod");
		if (PlayerPrefs.GetInt("GotHead") == 1)
		{
			Say ("Well at least i got my head back");
			Title ("Ford");
			Say ("I don't think that will help console Marv");
		}
		else
		{
			Say("I'm only halve the man i once was...");
			Title ("Ford");
			Say ("We're already going to have to deal with one sulking machine...");
			Say ("Cheer up Zap, you'll be able to drowned your depression in alcohol once we're back at Millies");
			Title ("Zaphod");
			Say ("You always know the right thing to say Ford");
		}
		
		if (PlayerPrefs.GetInt("GotPOVGun") == 1)
		{
			Say ("Well we have the POV gun, that might be useful...");
			Title ("Ford");
			Say ("Yeah maybe Marv can shoot you with it for a bit");
			Say ("That should make up for lost time");
		}
		else
		{
			Say("I don't have the POV gun anymore either");
			Title ("Ford");
			Say ("Marv used to enjoy that");
			Say ("You can tell him why it's gone");
			Title ("Zaphod");
			Say ("I have a feeling that I won't enjoy this...");
		}
		
		Title ("");
		Say ("Take us in");
		Title ("Ford");
		Say ("Hold tight");
		MoveToRoom(BackAtMillys);
	}
	
}