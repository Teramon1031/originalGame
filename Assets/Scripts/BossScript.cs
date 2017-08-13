using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour {

	public GameObject enemy;
	private float _timer;

	void Start () {
		_timer = 0.0f;
	}

	void Update () {
		_timer -= Time.deltaTime;
		if (_timer <= 0.0f) {
			Instantiate (enemy, transform.position, transform.rotation);
			_timer = 4.0f;
		}
	}
}