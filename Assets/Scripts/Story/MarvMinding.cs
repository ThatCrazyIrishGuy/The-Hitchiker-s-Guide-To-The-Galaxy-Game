using UnityEngine;
using System.Collections;
using Fungus;

public class MarvMinding : Room
{

	public Room GoingBack;

	void OnEnter() 
	{	 
		Title ("Marvin");
		Say ("Here I am, brain the size of a planet, and they ask me to hold the tables.");
		Say ("Call that job satisfaction, 'cause I don't...");
		MoveToRoom(GoingBack);
	}
	
	
}
