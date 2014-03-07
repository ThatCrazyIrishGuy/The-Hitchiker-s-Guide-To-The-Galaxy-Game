using UnityEngine;
using System.Collections;
using Fungus;

public class Begining : Room
{
	public Room Bridge;
	
	void OnEnter() 
	{	
		Say ("In the beginning the Universe was created.");
		Say ("This has made a lot of people very angry and has been widely regarded as a bad move.");
		Say ("Then a couple of million years happened and now we're here...");
		Say ("After Marvin correcting the ships course with all the merriment we have come to expect from him, that being none at all, " +
		     "Ford engaged the Infinite Improbability Drive and crossed his fingers.");
		Say ("Transmogrifying from a sea turtle to a bunch of grapes and finally settling on a collection of shaded voxels that some-what resembled their original form.");
		MoveToBridge();
		
		//AddOption("Playing music and sound effects", MoveToAudio);
		//Choose("Choose an example");
	}
	
		void MoveToBridge()
		{
			MoveToRoom(Bridge);
		}

}
