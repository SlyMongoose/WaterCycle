using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningInstruction : MonoBehaviour {

	public bool isPaused;
	public GameObject pauseMenuCanvas;

	void Awake() {
		Time.timeScale = 0f;
	}

	public void StartActivity () {
		pauseMenuCanvas.SetActive(false);
		Time.timeScale = 1f;
	}
}
