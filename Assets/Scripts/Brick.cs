using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public int hits = 1;
	public int points = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll) 
	{
		hits = hits -1;

		if (hits == 0) {
			gameObject.SetActive (false);
			FindObjectOfType<Ball2> ().BrickBroken(points);
		
		}
	
	}

}
