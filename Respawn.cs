using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {
	public int index;
	public string levelName;

	void OnTriggerEnter2D (Collider2D other)
	{
		//Restarts the level 
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}