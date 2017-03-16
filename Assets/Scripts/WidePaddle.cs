using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidePaddle : MonoBehaviour {

	public GameObject longpaddle;
	public GameObject shortpaddle;

	void OnCollisionEnter2D(Collision2D coll)
	{
		longpaddle.SetActive(true);
		shortpaddle.SetActive(false);

	}



}
