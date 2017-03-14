using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AumakuaController : MonoBehaviour {

	public string AumakuaName;
	public Text userChoice;
	public bool isChooseScene;
	public float tatooScale;

	void Awake() {
		if (!isChooseScene) {
			AumakuaName = GameControl.control.aumakua;
			userChoice.text = "You picked the " + GameControl.control.aumakua + "!";

			GameObject.Find("aumakua tatoo").GetComponent<SpriteRenderer>().sprite = Resources.Load(GameControl.control.aumakua, typeof(Sprite)) as Sprite;
			GameObject.Find("aumakua tatoo").GetComponent<Transform>().localScale = new Vector3(tatooScale, tatooScale, tatooScale);
		}
	}

	void OnMouseUp() {
		GameControl.control.aumakua = AumakuaName;
		SceneManager.LoadScene(3);
	}
}
