using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {
	
	//a switch statement is kind of like an if statement. First like we've done below, we have to state a variable. 
	public string townCenter = "Main";

	//Once we've declaired the variable, we declare the switch down in the void start. 

	public int loveMeter; 

	public string answer;

	public int intelligence;

	public int health;

	public string hunger;

	public string heroPower;

	public float phoneBattery;

	// Use this for initialization
	void Start () {
	//below, we have a switch. right after switch you'll enter the name of the varialbe you are comparing to for answers in ().
		switch(townCenter){
	//then you list your cases. Cases are possible asnwers. The switch statement will go through these and compare them to the value entered into the varialbe. 	
			case "main": 
				print("welcome to Main Street!");
			break;
	//you have to put a break at the end of the case. Break is what tells the switch to stop if this case matched the variable. Otherwise it will continue to list the cases afterward off.
			case "blacksmith":
				print("The blacksmtih grumbles as you pick through the sword bin."); break;
			case "bakery":
				print("Mmmmnnnnnn baked goods.") break;
			case "morgue":
				print("Peeeeeeeeeeyewww!"); break;
	// the very last one is the default. This is what is done if none of the cases match the variable. You don't have to have one, but it would be better to have one. 
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
		switch(answer){
			case "Yes":
				print("Good then, lets get started.");
			break;
			case "No":
				print("If that's how you want it.");
			break;
			default:
			print("Well, keep thinking on it.");
			break;
		}
		switch(intelligence){
			case 1:
				print("Your level is too low."); break;
			case 5:
				print("You're welcome to enter."); break;
			default:
				print("You are close, but not close enough."); break;
		}
		switch(health){
			case 1:
				print("You are in need of medical assistance."); break;
			case 10:
				print("You are at full health."); break;
			default:
				print("You are not at full capacity."); break;
		}
		switch(hunger){
			case "Hungry":
				print("Then eat something."); break;
			case "Full":
				print("Then get out of here! We're a restaurant!"); break;
			default:
				print("Im confused, what do you want?"); break;

		}
		switch(heroPower){
			case "frostbolt":
				print("You're an ice hero."); break;
			case "blast":
				print("You're a fire hero."); break;
			default:
				print("Sorry, I've only studied fire and ice heros."): break;
		}
		switch(phoneBattery){
			case 0.01f:
				print("Your phones about to die!"); break;
			case 0.50f:
				print("You're at half battery. You could use a charger."); break;
			case 1.00f: 
				print("You're at full battery."); break;
			default:
				print("You could use a charger, any battery gone is battery gone!"); break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
