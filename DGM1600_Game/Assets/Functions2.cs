using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The scope of information in C# is the area where information is avaialable. The brackets {} are the scope. With a function, any varialbes within the scope are ONLY available within the scope or function.
//The access modifier is stating wheather something is public or private.

public class Functions2 : MonoBehaviour {
	public int num1;
	public int num2;
	public void DoStuff(){
		print("I'm doing stuff...");
	}
	void Start(){
		DoStuff();
		int result = AddNumbers(num1, num2);
		print(result);

	}
	public int AddNumbers(int numb1, int numb2){
		int result = numb1 + numb2;

		return result;
	}

	
}
