using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess =500;
	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a no. in your head, but don't tell me!");
		
		
		print ("You can pick any no. between " +min +" to " +max);
		
		print ("Is your no. greater than or smaller than "+guess);
		print ("Press up key for greater than, down key for lower than and right key for equal than");	
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.UpArrow)){
		//print("Up arrow pressed");
		min = guess;
		guess = (min + max)/2;
		print("Higher or lower than " +guess);
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down arrow pressed");
		max = guess;
		guess = (min + max)/2;
		print("Higher or lower than " +guess);
			
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			print("I hope this no. you choosed.");
		}
	}
}
