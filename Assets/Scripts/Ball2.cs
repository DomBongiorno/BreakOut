using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball2 : MonoBehaviour {

	public Vector2 startingVelocity = new Vector2 (0,-10);
	private Vector3 startingPosition;
	public GameObject gameOver;
	public GameObject youWin;
	public Text livesValue;
	public Text scoreValue;

	int lives = 3;
	public int score = 0;

	void Start () 
	{
		startingPosition = transform.position;

		GetComponent<Rigidbody2D> ().velocity = startingVelocity;
	}


	void Update ()
	{
		if (transform.position.y < -4.8f) {
			GetOut ();
		}
		if (Input.GetButtonDown ("Jump")) {
			GetComponent<Rigidbody2D> ().velocity = startingVelocity;
		}
	}

	void GetOut()
	{
		lives = lives - 1;
		livesValue.text = lives.ToString();

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
		score =score + 10;
		scoreValue.text = score.ToString ();
		var bricksleft = FindObjectsOfType<Brick> ().Length;
		if (bricksleft == 0) 
		{
			youWin.SetActive (true);
		}
	}
}
