using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FirstOrder : IComparable<FirstOrder> {
	public string name;
	public int power;
	public FirstOrder(String newName, int newPower){
		name = newName;
		power = newPower;
	}
	
	public int CompareTo(FirstOrder other){
		if(other == null){
			return 1;
		}
		return power - other.power;
	}

}
