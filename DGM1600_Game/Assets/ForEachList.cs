using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachList : MonoBehaviour {

	void Start () {
		List<Heros> mages = new List<Heros>();

		mages.Add(new Heros("Jaina",15));
		mages.Add(new Heros("Li Ming",20));
		mages.Add(new Heros("Mathael",1000));
		mages.Add(new Heros("Kael", 22));

		// mages.Sort();

		foreach(mages guy in mages){
			print(guy.name + " "+ guy.power);
		}



	}
	
}
