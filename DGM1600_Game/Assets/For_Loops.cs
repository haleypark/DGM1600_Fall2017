using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loops : MonoBehaviour {
	// public int bottles = 100;
	void Start () {
		// while(bottles > 0)
		// 	print(bottles+"bottles of beer onthe wall.");
		// 	bottles -- ;
		for(int bottles = 100; bottles > 0; bottles -- ){
			print(bottles+"bottles of beer onthe wall.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
