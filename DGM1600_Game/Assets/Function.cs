using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour {
	public int laserBlast;
	// Use this for initialization
	void Start () {
		Deathstar(laserBlast);
	
	}
	
	// Update is called once per frame
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
}
