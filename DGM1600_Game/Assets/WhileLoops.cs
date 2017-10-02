using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

// A while loop is when you set a condition, and an action will go off until the condition is no longer true. This is why it is called a loop. 
//Its a way to set up a bunch of actions without doing them one by one.

	public int bottles = 100;

	public int pizzaSlices = 8;

	public int cupCakeTray = 6;
	
	public int coins = 25;

	public int badGuys = 10;

	public int lessons = 20;

	public int drinks = 6;

	public int dirtyRooms = 4;

	// in the below loop, we have that we will continue to sing bottles of bear on the wall, so long as the number of bottles is great than 0. After each action, it subtracts a number.
	void Start () {
		while(bottles > 0){
			bottles -- ;
<<<<<<< Updated upstream
			print(bottles + " bottles of beer on the wall!");
=======
			print(bottles + " bottles of beer on the way!");
			//because we have 100 bottles, this will go off 100 times. 
>>>>>>> Stashed changes
			
		}
		while(pizzaSlices > 0){
			pizzaSlices -- ;
			print("gotta eat till the whole pizza is gone!");
		}
		while(cupCakeTray <12){
			cupCakeTray ++ ;
			print("We need a dozon cupcakes, we have" + cupCakeTray);
		}
		while(coins < 50){
			coins ++ ;
			print("We need to collect till we have 50 coins!");
		}
		while(badGuys > 0){
			badGuys -- ;
			print("Keep getting them till they're all gone!");
		}
		while(lessons > 0){
			lessons -- ;
			print("GOtta do all the homework.");
		}
		while(drinks > 0){
			drinks -- ;
			print("You have to drink them all to win.");
		}
		while(dirtyRooms > 0){
			dirtyRooms -- ;
			print("You can't go out till all the rooms are clean.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
