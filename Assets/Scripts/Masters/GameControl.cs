using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	/*  Player Info variables */
	public bool newCharacter = true;
	public string daName;
	public string level;
	public string aumakua;
	public float age;
	public float experience;

	/*  Navigation scene variables */
	public bool navigationFT;
	public bool hiapoBorn;
	public string hiapoName;
	public float hiapoAge;
	public float hiapoExp;

	/*  Mele Activity variables */
	public bool meleFT;

	/*  Pahu Activity variables */
	public bool pahuFT;

	/*  Lo'i scene variables */
	public bool loiFT;
	public int pulledKalo;
	public int polokaCaught;

	/*  Kuke Activity variables */
	public bool kukeFT;

	/*  Ku'ikalo scene variables */
	public bool kuiKaloFT;

	/*  Inventory variables */
	public int poi;
	public int kaloRaw;
	public int kaloCooked;
	public int meat;
	public int fish;
	public int lauLeaves;
	public int lauPrepped;

	void Awake () {
		if (control == null)
		{
			DontDestroyOnLoad(gameObject);
			control = this;
		}
		else if (control != this) {
			Destroy(gameObject);
		}
	}

	void OnEnable () {
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData) bf.Deserialize(file);

			/*  Player Info variables */
			daName = data.daName;
			level = data.level;
			aumakua = data.aumakua;
			age = data.age;
			experience = data.experience;

			/*  Navigation scene variables */
			navigationFT = data.navigationFT;
			hiapoBorn = data.hiapoBorn;
			hiapoName = data.hiapoName;
			hiapoAge = data.hiapoAge;
			hiapoExp = data.hiapoExp;

			/*  Mele Activity variables */
			meleFT = data.meleFT;

			/*  Pahu Activity variables */
			pahuFT = data.pahuFT;

			/*  Lo'i scene variables */
			loiFT = data.loiFT;
			pulledKalo = data.pulledKalo;
			polokaCaught = data.polokaCaught;

			/*  Kuke Activity variables */
			kukeFT = data.kukeFT;

			/*  Ku'ikalo scene variables */
			kuiKaloFT = data.kuiKaloFT;

			/*  Inventory variables */
			poi = data.poi;
			kaloRaw = data.kaloRaw;
			kaloCooked = data.kaloCooked;
			meat = data.meat;
			fish = data.fish;
			lauLeaves = data.lauLeaves;
			lauPrepped = data.lauPrepped;

			file.Close();
		}
	}

	void OnDisable () {
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

		PlayerData data = new PlayerData();

		/*  Player Info variables */
		data.daName = daName;
		data.level = level;
		data.aumakua = aumakua;
		data.age = age;
		data.experience = experience;

		/*  Navigation scene variables */
		data.navigationFT = navigationFT;
		data.hiapoBorn = hiapoBorn;
		data.hiapoName = hiapoName;
		data.hiapoAge = hiapoAge;
		data.hiapoExp = hiapoExp;

		/*  Mele Activity variables */
		data.meleFT = meleFT;

		/*  Pahu Activity variables */
		data.pahuFT = pahuFT;

		/*  Lo'i scene variables */
		data.loiFT = loiFT;
		data.pulledKalo = pulledKalo;
		data.polokaCaught = polokaCaught;

		/*  Kuke Activity variables */
		data.kukeFT = kukeFT;

		/*  Ku'ikalo scene variables */
		data.kuiKaloFT = kuiKaloFT;

		/*  Inventory variables */
		data.poi = poi;
		data.kaloRaw = kaloRaw;
		data.kaloCooked = kaloCooked;
		data.meat = meat;
		data.fish = fish;
		data.lauLeaves = lauLeaves;
		data.lauPrepped = lauPrepped;

		bf.Serialize(file, data);
		file.Close();
	}
}

[Serializable]
class PlayerData
{

	public PlayerData() {
		newCharacter = true;
		navigationFT = true;
		hiapoBorn = false;
		meleFT = true;
		pahuFT = true;
		loiFT = true;
		kukeFT = true;
		kuiKaloFT = true;

		hiapoName = "notSet";
		hiapoAge = 0f;
		hiapoExp = 0f;

		// set food inventory items to 0
		poi = 0;
		kaloRaw = 0;
		kaloCooked = 0;
		meat = 0;
		fish = 0;
		lauLeaves = 0;
		lauPrepped = 0;

		//set scene variables
		pulledKalo = 0;
		polokaCaught = 0;

	}

	/*  Player Info variables */
	public bool newCharacter;
	public string daName;
	public string level;
	public string aumakua;
	public float age;
	public float experience;

	/*  Navigation scene variables */
	public bool navigationFT;
	public bool hiapoBorn;
	public string hiapoName;
	public float hiapoAge;
	public float hiapoExp;

	/*  Mele Activity variables */
	public bool meleFT;

	/*  Pahu Activity variables */
	public bool pahuFT;

	/*  Lo'i scene variables */
	public bool loiFT;
	public int pulledKalo;
	public int polokaCaught;

	/*  Kuke Activity variables */
	public bool kukeFT;

	/*  Ku'ikalo scene variables */
	public bool kuiKaloFT;

	/*  Inventory variables */
	public int poi;
	public int kaloRaw;
	public int kaloCooked;
	public int meat;
	public int fish;
	public int lauLeaves;
	public int lauPrepped;

	/*  Creation scene variables */
}
