using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class AllSceneChanges : MonoBehaviour{

	private Image clicked;
	private GameObject temp;
	public Sprite changeTo;

	public void LoadScene (int myInt) {
		SceneManager.LoadScene(myInt);
	}

	public void exitGame() {
		Application.Quit();
	}

	public void highlightButton(){
		temp = EventSystem.current.currentSelectedGameObject;
		clicked = temp.GetComponent<Image>();
		clicked.sprite = changeTo;
	}
}
