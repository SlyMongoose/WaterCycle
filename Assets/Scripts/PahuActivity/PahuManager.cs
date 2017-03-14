using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PahuManager : MonoBehaviour {

	public Slider pahuBar;
	public float storageCapacity;
	public HitBoxManager boxes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pahuBar.maxValue = storageCapacity;
		pahuBar.value = boxes.startValue;
	}
}
