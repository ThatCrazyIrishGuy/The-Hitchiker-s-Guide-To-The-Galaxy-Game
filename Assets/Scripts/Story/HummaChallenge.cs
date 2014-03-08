using UnityEngine;
using System.Collections;
using Fungus;

public class HummaChallenge : Room
{
	//public Room HummaChallenge;
	
	void OnEnter() 
	{	
		Title ("Humma");
		Say ("Zaphod Beeblebrox?");
		Title ("Zaphod");
		Say ("The one and only");
		Say ("Where's my head");
		Title ("Humma");
		Say ("We'll you certainly took you're time");
		Say ("All of the followers of the Great Green Arkleseizure have left me");
		Say ("You're head has been the only company i have had in a long time");
		Say ("So i propose a challange...");
		Say ("If you can scale the church from the inside and ring the bell you can take you're head and keep the point of view gun...");
		Say ("But if you fail, i keep both");
		AddOption ("Accpet Challange", TakeChallenge);
		AddOption ("Reject Challange", PassChallenge);
		Choose("Make your choice");
		//MoveToRoom(HummaChallenge);
	}
	
	void TakeChallenge()
	{
		Title ("Zaphod");
		Say ("You know Me...");
		Say ("I can never turn down a challenge");
		Title ("");
		Say ("Oh god...");
		Title ("Humma");
		Say ("You have three chances to reach the top");
		Say ("If you fail 3 times the challenge is over and you leave empty handed");
		Say ("Let the challenge commence!");
		Application.LoadLevel("platformer");
	}
	
	void PassChallenge()
	{
		Title ("Zaphod");
		Say ("I can't take that risk");
		Say ("Besides I'm sick of getting shot with this stuiped gun anyway");
		Title ("");
		Say ("Thank god...");
		Title ("Humma");
		Say ("Your choice");
		Say ("You may take you're head, now leave me in peace");
		Application.LoadLevel("StoryMid");
	}
	
}