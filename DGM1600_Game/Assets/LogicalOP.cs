using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOP : MonoBehaviour {
	public string luke = "Jedi";

	public string vader = "Sith";

	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";

	public int num1 = 10;

	public float num2 = 10.5f;




	// Use this for initialization
	void Start () {
		// if(luke == "Jedi" && vader =="Sith" ){
		// 	print("Luke, I am your father.");
		// }
		// else if(luke == "Jawa" && vader =="Sith"){
		// 	print("Utini!");
		// }

		// else if(luke=="Jedi" && vader=="Nanny"){
		// 	print("Luke, I am your Nanny.");
		// }
		// else{
		// 	print("The end.");
		// }

		// if(leia){
		// 	print("No, there is another.");

		// }
		// else if(!leia){
		// 	print("hurray!");

		// }
		// else
		// 	print("Han fired first");

		// if(lightSide== "Obi Wan" || darkSide== "Jar Jar Binks"){
		// 	print("Meeeza Evil Sith Lord.");
		// }
		// else if(lightSide == "Boba Fett" || darkSide =="Darth Maul"){
		// 	print("As you wish, my Master.");
		// }
		// else{
		// 	print("Not the youglings!");
		// }

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
