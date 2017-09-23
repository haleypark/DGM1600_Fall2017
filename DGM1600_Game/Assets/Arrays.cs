using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An array is a group of variables. But they must all be the same type of variables. If you set your array to a string, all variables within the array will also be strings.

public class Arrays : MonoBehaviour {

//below we have declared an array. the [] after the type is what tells the computer that this is an array. 
	public string[] heros = new string[6];

// You then name it, this one is named pizzaSlices. Then =, but what is different from a variable is that you have to say new and then the array type. 
	public int[] pizzaSlices = new int [4];

// the number is the [] is the amount of variables there will be in your array. In the one below there will be 7. then you end it with;
	public string[] bTS = new string [7];

	public float[] waterBottle = new float [4];

	public string[] zeldaWii = new string[4];

	public string[] rickAndMorty = new string [5];

	public string[] chocolateBars = new string[3];

	public string[] blizzardGames = new string[6];

	public string[] myHousehold = new string [3];

	public string[] myPets = new string [3];

//below in the void start we begin to list the variables within the array. 
		void Start () {
	heros[0] = "Tyrande";
	heros[1] = "Malfurian";
	heros[2] = "Diablo";
	heros[3] = "Nova";
	heros[4] = "Lucio";
	heros[5] = "Lunara";
			
	print(heros[0]);
// youll notice above that it goes from zero to 5, and in the above array we listed it as having 6 in the list. The list does have six, but we begin the placeholders at 0.
	pizzaSlices[0] = 1;
	pizzaSlices[1] = 2;
	pizzaSlices[2] = 3;
	pizzaSlices[3] = 4;

	print(pizzaSlices[0] + pizzaSlices[1] + pizzaSlices[2] + pizzaSlices[3] + "=" + "Full Pizza");
	// in this one, we said it had 4, so it goes from 0-3.

	bTS[0]="Jimin";
	bTS[1]="J-hope";
	bTS[2]="V";
	bTS[3]="Suga";
	bTS[4]="Rap Monster";
	bTS[5]="Jin";
	bTS[6]="Jungkook";

	print(bTs[0] + "and" + bTs[1] + "are the best.");

	waterBottle[0]= 0.25f;
	waterBottle[1]= 0.50f;
	waterBottle[2]= 0.75f;
	waterBottle[3]= 1.00f;
	
	print(watterbottle[3] + "equals full water bottle.");
	
	zeldaWii[0] = "WindWaker";
	zeldaWii[1] = "Twilight Princess";
	zeldaWii[2] = "Skyward Sword";
	zeldaWii[3] = "Breath of the Wild";

	print(zeldaWii[3]);

	rickAndMorty[0] = "Rick";
	rickAndMorty[1] = "Morty";
	rickAndMorty[2] = "Summer";
	rickAndMorty[3] = "Beth";
	rickAndMorty[4] = "Jerry";

	pring(rickAndMorty[0]);

	chocolateBars[0] = "Cookies and Cream";
	chocolateBars[1] = "Crunch";
	chocolateBars[2] = "Twix";
	
	print(chocolateBars[0]);

	blizzardGames[0] = "Heros of the Storm";
	blizzardGames[1] = "World Of Warcraft";
	blizzardGames[2] = "Hearthstone";
	blizzardGames[3] = "Diablo";
	blizzardGames[4] = "Starcraft";
	blizzardGames[5] = "Overwatch";

	pring(blizzardGames[0] + "is the best.");

	myHousehold[0] = "Haley";
	myHousehold[1] = "Jong Hwa";
	myHousehold[2] = "Beth";

	myPets[0] = "Rosie";
	myPets[1] = "Ash";
	myPets[2] = "Luna";
		}

	// Update is called once per frame
	void Update () {
		
	}
}
