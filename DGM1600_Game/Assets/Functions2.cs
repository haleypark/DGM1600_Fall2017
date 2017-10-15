using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The scope of information in C# is the area where information is avaialable. The brackets {} are the scope. With a function, any varialbes within the scope are ONLY available within the scope or function.
//The access modifier is stating wheather something is public or private. If left blank it defaults to private. If something is within a function, it is only avaialable inside the function.

//Most functions have parameters. The parameters are the varialbes we put in () after we set the function. This is where information passes through. we can then use those variables in our function.

//Some functions have returns. If it has a return, it is not a void function, for that is its definition. A void funtion has no return. A return is a new varialbe that we get from the action
// of the function. we then have to call the return outside of the function if we want to then recieve that return. It creates one, but you have to call it outside to actually see it. 


public class Functions2 : MonoBehaviour {
	public int num1;
	public int num2;
	
	
	void Start(){
		//in the void start we call the returns of our functions so the system will print the return. 
		int result = AddNumbers(num1, num2);
		print(result);

		int answer = SubtractNumbers(num1, num2);
		print(answer);
	//in this functions MyAnimals, we've given the variables values here, instead of calling up from our public variables above. This means the numbers are set here, not in the console.
		int animals = MyAnimals(2, 1);

		int sleep = HoursOfSleep(24, 20, 4);

		int maxMana = HerosMana(50);

		int maxHealth = HerosHealth(75);

		int maxAttackDmg = HerosAttackDmg(60);

		

	}


	public int AddNumbers(int numb1, int numb2){
		int result = numb1 + numb2;

		return result;
	}
	public int SubtractNumbers(int numb1, int numb2){
		int answer = numb1 - numb2;

		return answer;
	}
	public int MyAnimals(int cats, int dogs){
		int animals = cats + dogs;

		return animals;
	}
	public int HoursOfSleep(int hours, int homework, int socialLife){
		int sleep = hours - homework - socialLife;

		return sleep;
	}
	public int HerosMana(int intelligence){
		int maxMana = intelligence * 5

		return maxMana;
	}
	public int HerosHealth(int strength){
		int maxHealth = strength * 5

		return maxHealth;
	}
	public int HerosAttackDmg(int agility){
		int maxAttackDmg = agility * 5

		return maxAttackDmg;

	}
	
	
	
}
