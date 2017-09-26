using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

	public int bottles = 100;


	// Use this for initialization
	void Start () {
		while(bottles > 0){
			bottles -- ;
			print(bottles + " bottles of beer on the way!");
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
