using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heros = new string[6];

	

	

	// Use this for initialization
	void Start () {
	heros[0] = "Tyrande";
	heros[1] = "Malfurian";
	heros[2] = "Diablo";
	heros[3] = "Nova";
	heros[4] = "Lucio";
	heros[5] = "Lunara";
		
	print(heros[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
