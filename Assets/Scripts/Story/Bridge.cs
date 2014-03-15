using UnityEngine;
using System.Collections;
using Fungus;

public class Bridge : Room
{
	public View LookFord;
	public View LookTrill;
	public View LookZap;
	public View ViewDown;
	public View Main;

	bool LookedDown = false;
	bool LookedAround = false;
	bool WaitedForNorm = false;
	bool ConsoleNoticed = false;
	
	public Room Controls;
	
	void OnEnter() 
	{	
		Say ("You hobble towards the wall with one blocky hand clutching the spherical collection of cubes that was once your head.");
		PrintChoices();
		//AddOption("Playing music and sound effects", MoveToAudio);
		//Choose("Choose an example");
	}

	void PrintChoices()
	{
		if (ConsoleNoticed)
		{
			AddOption ("Approach The Console", ApproachConsole);
		}
		if (!LookedDown)
		{
			AddOption ("Look Down", LookDown);
		}

		if (!LookedAround)
		{
			AddOption ("Look Around", LookAround);
		}
		
		if (!WaitedForNorm)
		{
			AddOption("Wait For Normalization",WaitForNorm);
		}
		else
		{
			AddOption("Keep Waiting",WaitSomeMore);
		}
		
		Choose("What do you do?");
	}

	void LookDown()
	{
		PanToView (ViewDown,2f);
		Wait(1);
		PanToView (Main,2f);
		Say ("You look down to see your body perfectly flat and your trusty towel hanging awkwardly from your other hand.");
		Say ("As you start to think your diet is paying off you quickly remember your current locale...");
		Say ("Hurtling through space with two madmen, the woman of your dreams and a morose robot.");
		LookedDown = true;
		PrintChoices();
	}

	void LookAround()
	{
		Say ("Looking around you spot Ford fiddling with the command console");
		PanToView (LookFord,2f);
		Wait(1);
		PanToView (Main,2f);
		Say ("Zaphod sprawled across the floor taking his hourly nap");
		PanToView(LookZap,2f);
		Wait(1);
		PanToView (Main,2f);
		Say ("and Trillian peeking over Ford's shoulder, staring blankly with her big square eyes.");
		PanToView(LookTrill,2f);
		Wait(1);
		PanToView (Main,2f);
		LookedAround = true;
		ConsoleNoticed = true;
		PrintChoices();
	}
	
	void WaitForNorm()
	{
		Say ("you slump back against the wall and roll your head back.");
		Say ("A minute passes and nothing.");
		WaitedForNorm = true;
		PrintChoices();

	}
	
	void WaitSomeMore()
	{
		Say ("You move into the fetal position, how much longer can it take?");
		Say	("4 more uneventful minutes pass.");
		PrintChoices();
	}
	
	void ApproachConsole()
	{
		Say ("As you near them, Ford and Trillian turn around wearing worried looks.");
		Say	("Well you think they are worried looks");
		Say ("It's hard to tell when the extent of someone's facial expression is the deviation of two blocks making a smile or frown.");

				Title ("Ford");
				Say ("We have some bad news");
				
				Title("Trillian");
				Say ("The energy conduit in the normalizer is burnt out so we're stuck like this until we can replace it");

				Title ("");
				Say ("How could you possible know that?");

				Title ("Ford");
				Say ("Eddie told us...");
				Say ("Although he's a little slow as his quantum CPU seems to have been replaced by a Nintendo Entertainment System from Earth");

				 Title ("");
				 Say ("Not even a SNES?");
				 Say ("This is terrible");

				Title ("Ford");
				Say ("The good news is that we're within hyper drive distance of Milliways");

				Title ("");
				Say ("Which is?");

				Title ("Ford");
				Say ("The restaurant at the end of the Universe!");

				Title ("");
				Say ("What about the energy conduit and Eddie being 8-Bit?");

				Title ("Trillian");
				Say ("We can discuss it over dinner");

				Title ("");
				Say ("Okay, take us in");

		StartDocking();
	}

	void StartDocking()
	{
		MoveToRoom(Controls);
	}


}
