using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loops : MonoBehaviour {
//a for loop is a loop that does a bit of the same thing as the other loops, but everything is organized into one line.
//we start with for and then (). in the (), we initalize our varialbe, make a conditional and then and count up or down if we wish with -- or ++.
//if we want to initalize our varialbe outside of the for loop, we need to start it with ;. we also need a ; after each of the 3 parts. 	

public int pizza = 8;

public int teamMates = 4;

	void Start () {
	
		for(int bottles = 100; bottles > 0; bottles -- ){
			print(bottles+"bottles of beer onthe wall.");
		}
	
	//in the one below, we stated the variable outside of the loop.
		for(int pizza; pizza>0; pizza -- ){
			print("I have" + pizza + "pizza slices left.");
		}
	//in the one below, we are comparing our int to another in that exsists rather than a number we asign. 
		for(int healthPotions = 0; teamMates > healthPotions; healthPotions ++){
			print("I need enough potions for all my teammates!");
		}
		for(int mathProblems = 50; mathProblems > 0; mathProblems --){
			print("Another math problem down!");
		}
		for(int videos = 0; videos < 10; videos ++){
			print("Gotta what all the videos in my list.");
		}
		for(int homeworkHours = 100; homeworkHours > 0; homeworkHours --){
			print("Gotta get in my 100 hours of homework a week!");
		}
		for(int poptarts = 4; poptarts > 0; poptarts --){
			print("I want more poptarts!");
		}
		for(int shots = 6; shots > 0; shots --){
			print("Take another shot!");
		}
		for(int mana = 0; mana < 100; mana ++){
			print("I need more mana!");
		}
	}
		
	
	
	void Update () {
		
	}
}
