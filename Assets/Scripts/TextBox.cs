using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour {

	Text txt;
	private int lives = 3;

	void Start () {
		txt = GetComponent<Text> ();
		txt.text = "Lives: " + lives;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
