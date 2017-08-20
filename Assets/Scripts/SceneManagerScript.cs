// Buttonにつけるクラス用のスクリプト

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	public void GoStage1 () {
		SceneManager.LoadScene ("Stage1");
	}

	public void GoTitle () {
		SceneManager.LoadScene ("Title");
	}

	public void GoBossBattle () {
		SceneManager.LoadScene ("BossBattle");
	}
}
