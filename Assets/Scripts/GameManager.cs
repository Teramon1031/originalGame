using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject Cleartext;
	public GameObject enemies;
	public GameObject LifeText;
	public GameObject ChalkText;
	private float ClearInterval;

	void Start () {
		Cleartext.SetActive (false);
	}

	void Update () {
		if (enemies.transform.childCount == 0) {
			Clear ();
		} 
	}

	void Clear () {
		Cleartext.SetActive (true);
		LifeText.SetActive (false);
		ChalkText.SetActive (false);
		ClearInterval += Time.deltaTime;

		if (ClearInterval >= 2) {
			ClearInterval = 0;
			Cleartext.SetActive (false);
			LifeText.SetActive (true);
			ChalkText.SetActive (true);
			SceneManager.LoadScene ("Clear");
		}

	}
}
