using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -15);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
