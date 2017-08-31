using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	public GameObject sousaSetume;
	private AudioSource audio;

	void Awake() {
		audio = GetComponent<AudioSource> ();
	}

	public void GoStage1 () {
		SceneManager.LoadScene ("Stage1");
		audio.Play ();
	}

	public void GoTitle () {
		SceneManager.LoadScene ("Title");
		audio.Play ();
	}

	public void GoBossBattle () {
		int Clearint = ClearHanteiScript.LoadCleared ();
		if (Clearint == 1) {
			SceneManager.LoadScene ("BossBattle");
			audio.Play ();
		}
	}

	public void SousaSetume () {
		sousaSetume.SetActive (true);
		audio.Play ();
	}

	public void Sousa_Modoru () {
		sousaSetume.SetActive (false);
		audio.Play ();
	}
}
