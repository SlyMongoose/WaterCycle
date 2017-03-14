using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KuiKaloController : MonoBehaviour {
	public Text cookedKaloNumber;

	// Use this for initialization
	void Start () {
		cookedKaloNumber.text = GameControl.control.kaloCooked.ToString();
	}
}
