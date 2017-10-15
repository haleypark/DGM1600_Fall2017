using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heros : MonoBehaviour {
	public string name;
	public int attack;
	public Heros(String newName, int newAttack){
		name = newName;
		power = newAttack;
	}
	
	public int CompareTo(Heros other){
		if(other == null){
			return 1;
		}
		return power - other.power;
	}

}
