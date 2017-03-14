using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaHanauController : MonoBehaviour {

	public Text daName;
	public Text age;
	public Text AgeExpLevel;
	public Text congrats;

	public float tatooScale;

	// Use this for initialization
	void Awake() {
		GameObject.Find("PlayerTatoo").GetComponent<SpriteRenderer>().sprite = Resources.Load(GameControl.control.aumakua, typeof(Sprite)) as Sprite;
		GameObject.Find("PlayerTatoo").GetComponent<Transform>().localScale = new Vector3(tatooScale, tatooScale, tatooScale);

		daName.text = GameControl.control.daName;
		age.text = GameControl.control.age.ToString();
		AgeExpLevel.text = "Age:  \n Exp: " + GameControl.control.experience + "\n Level: " + GameControl.control.level;
		congrats.text = "Hau'oli La Hanau \n You are " + GameControl.control.age.ToString() + "!";

	}
}
