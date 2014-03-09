using UnityEngine;
using System.Collections;
using Fungus;

public class MarvTalk : Room 
{
	public Room Max;

	void OnEnter()
	{
	}
	
	public void FirstReply()
	{
		Title ("Marvin");
		Say ("Brillant...");
		Max.GetComponent<MaxTalk>().FirstReply();
	}
	
	public void SecondReply()
	{
		Title ("Marvin");
		Say ("Fantastic, I might as well be back on the Heart of Gold");
		Max.GetComponent<MaxTalk>().SecondReply();
	}
	
	public void ThirdReply()
	{
		Title ("Marvin");
		Say ("I'll be fine, not that you care");
		Max.GetComponent<MaxTalk>().ThirdReply();
	}
}
