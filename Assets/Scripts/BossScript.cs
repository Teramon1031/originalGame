using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class BossScript : MonoBehaviour {

	public static int bossHP;
	public static bool bossLife;
	public GameObject enemy;
	public GameObject gcText;
	public GameObject gcButA;
	public GameObject gcButB;
	private float _timer;
	private GameObject _player;
	private Transform _target;
	private Animator _anim;

	NavMeshAgent agent;

	void Awake () {
		agent = GetComponent<NavMeshAgent> ();
		_player = GameObject.FindGameObjectWithTag ("player");
		_anim = GetComponent<Animator> ();
	}

	void Start () {
		_timer = 0.0f;
		bossHP = 8;
		bossLife = true;
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
			bossLife = false;
		}
	}

	void EnemyDamageSetBoolFalse(){
		_anim.SetBool ("EnemyDamage", false);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "eraser") {
			bossHP--;
			_anim.SetBool ("EnemyDamage",true);
			Destroy (col.gameObject);
			Debug.Log (bossHP);
			Invoke ("EnemyDamageSetBoolFalse", 1.0f);
		}	
	}
}