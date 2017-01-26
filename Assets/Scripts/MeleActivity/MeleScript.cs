using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleScript : MonoBehaviour {

	public SpriteRenderer[] swirls;
	public AudioSource[] buttonSounds;
	private int colourSelect;

	public float stayLit;
	private float stayLitCounter;

	public float waitBetweenLights;
	private float waitBetweenCounter;

	private bool shouldBeLit;
	private bool shouldBeDark;

	public List<int> activeSequence;
	private int positionInSequence;

	private bool gameActive;
	private int inputInSequence;

	public AudioSource correct;
	public AudioSource incorrect;

	public Text scoreText;
	private bool shouldWaitForNextSequence;
	public float waitBetweenSequences;
	private float sequenceWait;

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey("HiScore")) {
			PlayerPrefs.SetInt("HiScore", 0);
		}
		scoreText.text = "Score: 0 - High Score: " + PlayerPrefs.GetInt("HiScore");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(shouldBeLit) {
			stayLitCounter -=Time.deltaTime;

			if (stayLitCounter < 0) {
				swirls[activeSequence[positionInSequence]].color = new Color(swirls[activeSequence[positionInSequence]].color.r - 125, swirls[activeSequence[positionInSequence]].color.g - 125, swirls[activeSequence[positionInSequence]].color.b - 125);
				buttonSounds[activeSequence[positionInSequence]].Stop();
				shouldBeLit = false;

				shouldBeDark = true;
				waitBetweenCounter = waitBetweenLights;

				positionInSequence++;
			}
		}

		if (shouldBeDark) {
			waitBetweenCounter -= Time.deltaTime;

			if(positionInSequence >= activeSequence.Count) {
				shouldBeDark = false;
				gameActive = true;
			}
			else {
				if (waitBetweenCounter < 0) {
					swirls[activeSequence[positionInSequence]].color = new Color(swirls[activeSequence[positionInSequence]].color.r + 125, swirls[activeSequence[positionInSequence]].color.g + 125, swirls[activeSequence[positionInSequence]].color.b + 125);
					buttonSounds[activeSequence[positionInSequence]].Play();

					stayLitCounter = stayLit;
					shouldBeLit = true;
					shouldBeDark = false;
				}
			}
		}
	}

	public void StartGame()
	{
		activeSequence.Clear();

		positionInSequence = 0;
		inputInSequence = 0;

		colourSelect = Random.Range(0, swirls.Length);

		activeSequence.Add(colourSelect);

		swirls[activeSequence[positionInSequence]].color = new Color(swirls[activeSequence[positionInSequence]].color.r + 125, swirls[activeSequence[positionInSequence]].color.g + 125, swirls[activeSequence[positionInSequence]].color.b + 125);
		buttonSounds[activeSequence[positionInSequence]].Play();

		stayLitCounter = stayLit;
		shouldBeLit = true;

		scoreText.text = "Score: 0 - High Score: " + PlayerPrefs.GetInt("HiScore");
	}

	public void ColourPressed(int whichButton) {
		if (gameActive == true)
		{
			if (activeSequence[inputInSequence] == whichButton)
			{
				Debug.Log("Correct!");

				inputInSequence++;

				if(inputInSequence >= activeSequence.Count)
				{
					correct.Play();
					StartCoroutine(Example());
				}
			}
			else {
				Debug.Log("wrong!");
				incorrect.Play();

				gameActive = false;
			}
		}
	}

	IEnumerator Example() {
		yield return new WaitForSecondsRealtime(waitBetweenSequences);

		if(activeSequence.Count > PlayerPrefs.GetInt("HiScore")) {
			PlayerPrefs.SetInt("HiScore", activeSequence.Count);
		}
		scoreText.text = "Score: " + activeSequence.Count + " - High Score: "  + PlayerPrefs.GetInt("HiScore");

		positionInSequence = 0;
		inputInSequence = 0;

		colourSelect = Random.Range(0, swirls.Length);

		activeSequence.Add(colourSelect);

		swirls[activeSequence[positionInSequence]].color = new Color(swirls[activeSequence[positionInSequence]].color.r + 125, swirls[activeSequence[positionInSequence]].color.g + 125, swirls[activeSequence[positionInSequence]].color.b + 125);
		buttonSounds[activeSequence[positionInSequence]].Play();

		stayLitCounter = stayLit;
		shouldBeLit = true;

		gameActive = false;
	}

}
