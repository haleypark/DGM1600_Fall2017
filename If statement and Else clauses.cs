using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2 : MonoBehaviour {

	public string shirtColor = "Blue";
	// We use whats called "if statements" so that if we decide to change the int, the outcome will change as well. So the varialbe above has shirtColor, and we've picked blue. We will do some If statements to change that

void Start(){
	Main();
}
void Main(){
	
	if(shirtColor == Blue){
		print("I like your shirt! Blue rules.");
	}
// this above is the if statement. For a variable, it can only have one if statement. The variable will check this first, and if they match, it will use it. If not it moves on.

	if else(shirtColor == Red){
		print("Red! The devils color!");
	}
	// The above is the if else statment. this will come after the initial if statement. Though you can only have ONE If statement, you can have as many if else statements you want. 

	else(shirtColor == Green){
		print("Green is the color of nature.")
	}
	//these if, if else and the else statements use == rather than just =. because these are conditional of the input of the origonal varialbe.
	//the else statement is the end of the string, bascially. The last box that gets checked. we only get to here if all other set up before did not match. 



}
	public int health =  100;

void Start(){
	Main();
}
void Main(){

	if(health == 100){
		print("you are at full health");
	}
	//this is the If statement again. Remember there is only 1 if statement, and it is the first one checked.
	if else(health == 70){
		print("You are lightly injured. Eat a potato.");
	}

	if else (health == 40){
		print("You are very injured. Seek medical help.");
	}

	else(health ==20){
		print("You are about to die, Seek imidiate help.");
		//there is only 1 else statement as well, the last onthe list.
	}

}
