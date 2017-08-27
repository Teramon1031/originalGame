using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class BossScript : MonoBehaviour {

	public static int bossHP;
	public GameObject enemy;
	public GameObject gcText;
	public GameObject gcButA;
	public GameObject gcButB;
	private float _timer;
	private GameObject _player;
	private Transform _target;


	NavMeshAgent agent;

	void Awake () {
		agent = GetComponent<NavMeshAgent> ();
		_player = GameObject.FindGameObjectWithTag ("player");
	}

	void Start () {
		_timer = 0.0f;
		bossHP = 10;
	}

	void Update () {
		_target = _player.transform;
		_timer -= Time.deltaTime;
		agent.SetDestination (_target.position);
		if (_timer <= 0.0f) {
			Instantiate (enemy, transform.position, transform.rotation);
			_timer = 8.0f;
		}
		if (bossHP <= 0) {
			gcText.SetActive (true);
			gcButA.SetActive (true);
			gcButB.SetActive (true);
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "eraser") {
			bossHP--;
		}			
	}
}