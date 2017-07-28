using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	private bool playerLife = true;
	public static int playerHP = 5;
	private float interval;

//	public Text LifeText;

	void Update () {
		interval += 1 * Time.deltaTime;
		if (playerHP <= 0 && playerLife == true) {
			playerLife = false;
			SceneManager.LoadScene ("GameOver");
			playerHP = 5;
		}
		if (interval >= 10) {
			if (playerHP < 5) {
				playerHP++;
			}
			interval = 0;
		}
		if (playerHP <= 0) {
			playerHP = 0;
		}

//		LifeText.text = "LIFE : \t" + playerHP.ToString ();

	}
}