// Buttonにつけるクラス用のスクリプト

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	public void DoReplay () {
		SceneManager.LoadScene ("Stage1");
	}

	public void DoReturnToTitle () {
		SceneManager.LoadScene ("Title");
	}

	public void GameStart1 () {
		SceneManager.LoadScene ("Stage1");
	}

	public void GameStart3 () {
		SceneManager.LoadScene ("Stage3");
	}
}
