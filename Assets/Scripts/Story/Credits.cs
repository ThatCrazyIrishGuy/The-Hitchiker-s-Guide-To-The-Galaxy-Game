using UnityEngine;
using System.Collections;
using Fungus;

public class Credits : Room
{
	public View InspiredBy;
	public View Bryan;
	public View Snoz1;
	public View Snoz2;
	
	void OnEnter() 
	{
		audio.Play();
		Wait(3); 
		PanToView (InspiredBy,2f);
		Wait(3);
		PanToView (Bryan,2f);
		Wait(2);
		PanToView (Snoz1,2f);
		Wait(2);
		PanToView (Snoz2,2f);
		Wait(2);
		AddOption ("Exit", EndGame);
		Choose("");

	}
	
	void EndGame()
	{
		audio.Stop();
		Application.Quit();
	}
	
}