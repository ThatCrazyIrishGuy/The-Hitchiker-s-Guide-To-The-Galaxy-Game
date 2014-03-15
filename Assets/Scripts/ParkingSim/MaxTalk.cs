using UnityEngine;
using System.Collections;
using Fungus;

public class MaxTalk : Room 
{
	public Room Marv;
	public GameObject car;

	void OnEnter()
	{
		Title ("Max");
		
		Say ("Okay Marvin, we have finally found you a job");
		Marv.GetComponent<MarvTalk>().FirstReply();
	}
	
	public void FirstReply()
	{
		Title ("Max");
		
		Say ("So you're going to be parking space cars in our holographic parking lot");
		Marv.GetComponent<MarvTalk>().SecondReply();
	}
	
	public void SecondReply()
	{
		Title ("Max");
		
		Say ("If you want to keep staying here, you have to pull your weight");
		Say ("We needed a robot to do this because we have noticed some bugs in our holographic simulation");
		Say ("If you see anything strange, turn back");
		Marv.GetComponent<MarvTalk>().ThirdReply();
	}
	
	public void ThirdReply()
	{
		Title ("Max");
		
		Say ("Okay, lets get started");
		Say ("Go ahead and find the parking spot for that car");
		AddOption ("Start", EnableCarControl);
		Choose("");
	}
	
	void EnableCarControl()
	{
		Wait (5);
		Debug.Log ("Max Fun called");
		car.GetComponent<PlayerControl>().ToggleInput();
	}
}
