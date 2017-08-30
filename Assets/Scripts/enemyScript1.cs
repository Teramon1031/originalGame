/* 敵がプレイヤーを追従し常にプレイヤーをむく
 * 5秒ごとに武器を発射
 * プレイヤーにぶつかるプレイヤーのHPを0になる
 * プレイヤーの武器が当たるとダメージを受ける  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyScript1 : MonoBehaviour {
	
	private GameObject _player;
	private Transform _target;
	public Transform muzzle;
	public GameObject weaponA;
	public Animator enemyAnim;
	public GameObject eraser;
	private float _interval;
	private int _enemyHP = 3;
	private bool _enemyWalk;
	private bool _enemyLive;

	NavMeshAgent agent;

	void Awake () {
		agent = GetComponent<NavMeshAgent> ();
		_player = GameObject.FindGameObjectWithTag ("player");
	}

	void Start () {
		_enemyWalk = true;
		_enemyLive = true;
	}
		
	void Update () {
		_target = _player.transform;
		if (_enemyWalk) {
			agent.SetDestination (_target.position);
		}
		if (_enemyHP <= 0 && _enemyLive) {
			_enemyWalk = false;
			enemyAnim.SetBool ("EnemyDeath", true);

			Instantiate (eraser, transform.position, transform.rotation);
			_enemyLive = false;
			Destroy (this.gameObject, 0.5f);
		}
		_interval += 1 * Time.deltaTime;
		if (_interval > 3) {
			Instantiate (weaponA, muzzle.transform.position, muzzle.transform.rotation);
			_interval = 0;
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "player" && _enemyLive) {
			PlayerScript.playerHP = 0;
		}
		if (col.gameObject.tag == "chalk") {
			_enemyHP--;
			if (_enemyHP > 0) {
				_enemyWalk = false;
				enemyAnim.SetBool ("EnemyDamage", true);
				Invoke ("EnemyDamageSetBoolFalse", 1.0f);
			}
		}
		if (col.gameObject.tag == "ChalkGrenade") {
			_enemyHP -= 3;
			if (_enemyHP > 0) {
				_enemyWalk = false;
				enemyAnim.SetBool ("EnemyDamage", true);
				Invoke ("EnemyDamageSetBoolFalse", 1.0f);
			}
		}
	}

	void EnemyDamageSetBoolFalse(){
		enemyAnim.SetBool ("EnemyDamage", false);
		_enemyWalk = true;
	}
 
}
