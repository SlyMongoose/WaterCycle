using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoController : MonoBehaviour {

	public Text playerInfo;
	public float tatooScale;

	// Use this for initialization
	void Awake() {
		GameObject.Find("PlayerTatoo").GetComponent<SpriteRenderer>().sprite = Resources.Load(GameControl.control.aumakua, typeof(Sprite)) as Sprite;
		GameObject.Find("PlayerTatoo").GetComponent<Transform>().localScale = new Vector3(tatooScale, tatooScale, tatooScale);

		playerInfo.text = GameControl.control.daName + "\n Age: " + GameControl.control.age + "\n Exp: " + GameControl.control.experience;;
	}
}
