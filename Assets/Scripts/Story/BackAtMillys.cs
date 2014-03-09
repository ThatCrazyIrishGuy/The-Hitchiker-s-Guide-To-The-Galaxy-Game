using UnityEngine;
using System.Collections;
using Fungus;

public class BackAtMillys : Room
{
	//public Room HummaChallenge;
	
	void OnEnter() 
	{	
		Title ("Marvin");
		Say ("Where have you been all this time?");
		Title ("");
		Say ("We're sorry");
		Title ("Trillian");
		Say ("We know we took longer then we expect...");
		Title ("Marvin");
		Say ("Yes approximately 5376000 million years longer than expected...");
		Title ("Ford");
		Say ("What are you talking about Marvin");
		Say ("It was at most two and a half hours");
		Title ("Max");
		Say ("Oh no, what he is saying is correct");
		Say ("Marven has been a lodger here since as long as anyone can remember");
		Title ("Ford");
		Say ("The spent power conduit must have caused the IID to malfunction and send us forward in time");
		Say ("But Marven, what have you been doing for all this time");
		Title ("Marven");
		Say ("They gave me a job parking hover cars...");
		Application.LoadLevel("lvl1");
		//MoveToRoom(HummaChallenge);
	}
}