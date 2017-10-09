using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// void function is an operation in Csharp that proccesses information. because we use the word void, we have a function that will not give us an output or return. We can still get a print.
//for the first one, we named the function void deathstar. We have to put the deathstar function inthe void start function. Then rather than assigning it a number, we input an already establish variable.
//it will use the int from laserblast as the int for vent, which we declared an int inthe void deathstar function. 

public class Function : MonoBehaviour {
	public int laserBlast;

	public bool positiveNumber = true;

	public int rabbits = 2;
	// Use this for initialization
	void Start () {
		Deathstar(laserBlast);

		Addition(positiveNumber);
	
		Hunger(rabbits);
	}
	

	void Update () {

	}

void Deathstar (int vent){
		print("That's no moon, that's a space station.");

		if(vent == 1){
			print("Pokin's misses the mark.");
		}
		else if(vent == 2){
			print("Red leader misses.");
		}
		else{
			print("Death Star blows up!");
		}
	}
void Addition (bool num){
	if(num){
		print("This was addition.");
	}
	else(!num){
		print("This was not addition");

	}
	
}
void Hunger (int food){
	if(food > 3){
		print("we have enough for the night.");
	}
	else{
		print("we must hunt for more food.");
	}
}
void 
}
