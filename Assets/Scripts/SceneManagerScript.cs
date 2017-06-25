using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoReplay () {
		SceneManager.LoadScene ("Main");
	}

	public void DoReturnToTitle () {
		SceneManager.LoadScene ("Title");
	}

	public void GameStart () {
		SceneManager.LoadScene ("Main");
	}
}
