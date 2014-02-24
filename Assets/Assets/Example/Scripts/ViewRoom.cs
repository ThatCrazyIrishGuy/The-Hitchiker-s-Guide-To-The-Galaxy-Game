using UnityEngine;
using System.Collections;
using Fungus;

public class ViewRoom : Room 
{
	public Room TheBridge;

	public View mainView;
	public View logoView;
	public View toadstoolView;

	void OnEnter()
	{
		SetView(mainView);

		AddOption("Lets look at some blank background", LookLogo);
		AddOption("Hows about some cut off letters?", LookToadstool);
		AddOption("Back to menu", MoveToMenu);

		Choose("Wanna move the camera?");
	}

	void MoveToMenu()
	{
		MoveToRoom(TheBridge);
	}

	void LookLogo()
	{
		PanToView(logoView, 2f);
		Wait(2);
		PanToView(mainView, 2f);
		Call(OnEnter);
	}

	void LookToadstool()
	{
		FadeToView(toadstoolView, 2f);
		Say ("Now them is some pretty letter tops");
		Say("Hey - let's go look at the blank background!");
		Call(LookLogo);
	}
}
