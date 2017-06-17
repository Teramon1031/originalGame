using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {
	
	static public int EnemyHP = 5;
	public GameObject player;

	void Start () {
		
	}

	void Update () {
		if (EnemyHP == 0) {
			Destroy (this.gameObject);
		}

		Vector3 playerPos = player.transform.position;
		Vector3 enemyPos = this.transform.position;
		float dis = Vector3.Distance (playerPos, enemyPos);

		if (dis < 2) {
			Debug.Log ("GameOver!");
		}
	}
}
