using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject enemy;

	void Start () {
		for (int i = 1; i < 10; i++) {
			Instantiate (enemy, new Vector3 (Random.Range (8f, 10f), -0.4f, Random.Range (13f, 25f)), transform.rotation);
		}
	}

	void Update () {

	}
		
}
