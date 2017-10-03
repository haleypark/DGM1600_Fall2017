using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOP : MonoBehaviour {
//A logical Operater takes multiple variables and finds if they are both true, or if just one is true. 
//below are all variables. 
	public string luke = "Jedi";

	public string vader = "Sith";

	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";

	public int num1 = 10;

	public float num2 = 10.5f;

// public string joe = "Happy";

// public string wanda = "Crazy";

// public string parents = "angry";

// if(joe == "Happy" && wanda == "Happy"){
// 	print("We can do this!");
// }
// if else(joe == "Happy" && wanda == "crazy"){
// 	print("This won't do. Whats wrong with you?!");
// }
// if else(wanda == "crazy" || parents = "happy"){
// 	print("You're not welcome here!");
// }


	//here we will take the varialbes and set conditions for them. but there will be two different comparisions. 
	void Start () {
		//we use the == to say we are comparing one to the other. One = would me equal to. 
		//The && states that we have a second variable and both need to be true for this statement. 
		if(luke == "Jedi" && vader =="Sith" ){
			print("Luke, I am your father.");
		}
		else if(luke == "Jawa" && vader =="Sith"){
			print("Utini!");
		}

		else if(luke=="Jedi" && vader=="Nanny"){
			print("Luke, I am your Nanny.");
		}
		else{
			print("The end.");
		}

		if(leia){
			print("No, there is another.");

		}
		else if(!leia){
			print("hurray!");

		}
		else
			print("Han fired first");
	//below is similar to && but rather than both needing to be true, only one or the other has to be true with ||.
	// even if other statments also meet the condition, it will stop at whichever line meets it first, they go in order. 

		if(lightSide== "Obi Wan" || darkSide== "Jar Jar Binks"){
			print("Meeeza Evil Sith Lord.");
		}
		else if(lightSide == "Boba Fett" || darkSide =="Darth Maul"){
			print("As you wish, my Master.");
		}
		else{
			print("Not the youglings!");
		}

		if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if(num1 == 10 || num2 == 10){
			print("Nooooooooo! I mean Yes!");
		}
		else
			print("Utinni");
		}
		
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
