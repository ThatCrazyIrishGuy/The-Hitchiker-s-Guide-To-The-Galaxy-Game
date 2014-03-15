using UnityEngine;
using System.Collections;
using Fungus;

public class HummaChallenge : Room
{
	//public Room HummaChallenge;
	int GotHead = 0;
	int GotPOVGun = 0;
	
	void OnEnter() 
	{	
		Title ("Humma");
		Say ("Zaphod Beeblebrox?");
		Title ("Zaphod");
		Say ("The one and only");
		Say ("Gimme back my head, I have the gun");
		Title ("Humma");
		Say ("We'll you certainly took your time");
		Say ("All of the followers of the Great Green Arkleseizure have left me");
		Say ("Your head has been the only company i have had in a long time");
		Title ("");
		Say ("Does he mean....");
		Title("Humma");
		Say ("So i propose a challenge...");
		Say ("If you can scale the church from the inside and ring the bell you can take your head and keep the point of view gun...");
		Say ("But if you fail, i keep both");
		AddOption ("Accept Challenge", TakeChallenge);
		AddOption ("Reject Challenge", PassChallenge);
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
		AddOption ("Start Challenge", TakeChallenge);
		Choose("");
		LoadChallenge();
	}
	
	void LoadChallenge()
	{
		Application.LoadLevel("Sidescroller");
	}
	
	void PassChallenge()
	{
		Title ("Zaphod");
		Say ("I can't take that risk");
		Say ("Besides I'm sick of getting shot with this stupid gun anyway");
		Title ("");
		Say ("Thank god...");
		Title ("Humma");
		Say ("Your choice");
		Say ("You may take your head, now leave me in peace");
		GotHead = 1;
		PlayerPrefs.SetInt("GotHead",GotHead);
		PlayerPrefs.SetInt("GotPOVGun",GotPOVGun);
		AddOption ("Leave the Temple", LeaveTemple);
		Choose("");
	}
	
	void LeaveTemple()
	{
		Application.LoadLevel("StoryMid");
	}
	
}