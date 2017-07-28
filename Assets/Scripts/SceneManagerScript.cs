// Buttonにつけるクラス用のスクリプト

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

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
