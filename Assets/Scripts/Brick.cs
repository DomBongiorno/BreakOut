using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public int hits = 1;
	int bricks = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		hits = hits -1;

		if (hits == 0) {
			Break();
			bricks = bricks - 1;
		}
	
	}
	void Break(){
		gameObject.SetActive (false);
	}


}
