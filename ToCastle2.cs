﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCastle2: MonoBehaviour {

	public int index;
	public string levelName;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (index);
			SceneManager.LoadScene (levelName);
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
