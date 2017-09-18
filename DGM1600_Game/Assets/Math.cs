using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {
	public float valueOne;

	public float valueTwo; 

	private float result; 

	public float valueThree;

	public float valueFour;


	// Use this for initialization
	void Start () {
		DoMath();
	}
	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne +"+" + valueTwo + "=" +  result);

		result = valueOne - valueTwo;
		print(valueOne + "-" + valueTwo + "=" + result);

		result = valueOne * valueTwo;
		print(valueOne + "*" + valueTwo + "=" + result);

		result = valueOne / valueTwo;
		print(valueOne + "/" + valueTwo + "=" + result);

		result = valueThree + valueFour;
		print(valueThree + "+" + valueFour + "=" + result);

		result = valueThree - valueFour;
		print(valueThree + "-"+ valueFour + "=" + result);

		result = valueThree * valueFour;
		print(valueThree + "*"+ valueFour + "=" + result);

		result = valueThree / valueFour;
		print(valueThree + "/"+ valueFour + "=" + result);

	




	}
	// Update is called once per frame
	void Update () {
		
	}
}
