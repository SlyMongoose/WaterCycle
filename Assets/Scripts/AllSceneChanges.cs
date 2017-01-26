using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllSceneChanges : MonoBehaviour {

	public void LoadScene (int myInt) {
		SceneManager.LoadScene(myInt);
	}

	public void exitGame() {
		Application.Quit();
	}
}
