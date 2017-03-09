using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector2 startingVelocity = new Vector2 (0,-15);
	private Vector3 startingPosition;
	public GameObject gameOver;

	int lives = 3;

	void Start () 
	{
		startingPosition = transform.position;

		GetComponent<Rigidbody2D> ().velocity = startingVelocity;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y < -1.5f) {
			GetOut ();
		}
		if (Input.GetButtonDown ("Jump")) {
			GetComponent<Rigidbody2D> ().velocity = startingVelocity;
		}
	}

	void GetOut()
	{
		lives = lives - 1;

		transform.position = startingPosition;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 ();

		if (lives == 0) {
			GameOver ();
		}
	}

	void GameOver()
	{
		gameOver.SetActive (true);
	}

	public void BrickBroken()
	{
		var bricksleft = FindObjectsOfType<Brick> ().Length;
		if (bricksleft == 0) 
		{
			Application.LoadLevel ("Level2");
		}
	}
}
