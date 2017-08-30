using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearHanteiScript : MonoBehaviour {

	public Button bossButton;

	void Start() {
		PlayerPrefs.SetInt ("CLEARSTAGE", 0);
		bossButton.interactable = false;
	}

	void Update() {
		int ClearStage = PlayerPrefs.GetInt("CLEARSTAGE");
		if (ClearStage == 1) {
			bossButton.interactable = true;
		}

	}
}
