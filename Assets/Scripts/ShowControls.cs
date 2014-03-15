using UnityEngine;
using System.Collections;
using Fungus;

public class ShowControls : Room
{	

	public string sceneName = "Default";
	
	void OnEnter() 
	{
		Delay();
		AddOption ("Start", MoveToScene);
		Choose("Hold your device flat");
	}
	
	void Delay()
	{
		Wait(5);
	}
	
	void MoveToScene()
	{
		Application.LoadLevel(sceneName);
	}
	
}