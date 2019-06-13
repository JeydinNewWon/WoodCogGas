using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement2 : MonoBehaviour {

		public void PlayGame () {

			SceneManager.LoadScene("Maps2");
		}
		public void QuitGame () {
			Application.Quit();
		}
}
