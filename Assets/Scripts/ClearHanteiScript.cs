using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearHanteiScript : MonoBehaviour {

	int SavedKey = 0;

	void Start() {
		PlayerPrefs.SetInt ("Savedint", 0);
	}

	public static void SavedCleared(int a){
		PlayerPrefs.SetInt ("Savedint", a);
		int b = PlayerPrefs.GetInt ("Savedint");
		PlayerPrefs.Save ();
	}
	public static int LoadCleared(){
		int loadedScore;
		loadedScore = PlayerPrefs.GetInt ("Savedint");
		return loadedScore;
	}
}
