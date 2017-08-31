using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearHanteiScript : MonoBehaviour {

	void Start(){
		if (!PlayerPrefs.HasKey ("Savedint")) {
			PlayerPrefs.SetInt ("Savedint", 0);
			Debug.Log ("作った");
		}
		Debug.Log(PlayerPrefs.GetInt("Savedint"));
	}

	public static void SavedCleared(int a){
		PlayerPrefs.SetInt ("Savedint", a);
		int b = PlayerPrefs.GetInt ("Savedint");
		Debug.Log ("score=" + b + "セーブした");
		PlayerPrefs.Save ();
	}
	public static int LoadCleared(){
		int loadedScore;
		loadedScore = PlayerPrefs.GetInt ("Savedint");
		Debug.Log ("score=" + loadedScore + "ロードした");
		return loadedScore;
	}
}
