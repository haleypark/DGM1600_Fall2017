using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {
	public string townCenter;

	public int loveMeter; 

	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main": 
				print("welcome to Main Street!");
			break;
			case "blacksmith":
				print("The blacksmtih grumbles as you pick through the sword bin.");
			break;
			case "bakery":
				print("Mmmmnnnnnn baked goods.");
			break;
			case "morgue":
				print("Peeeeeeeeeeyewww!");
			break;
			default:
			print("I don't know what you're talking about!");
			break;
			}
		
		switch(loveMeter){
			case 1:
				print("You're crazy!");
				break;
			case 2:
				print("Are you sure?");
				break;
			case 3:
				print("Everything will be okay.");
				break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
