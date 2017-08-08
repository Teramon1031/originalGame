/* 敵がプレイヤーを追従し常にプレイヤーをむく
 * 5秒ごとに武器を発射
 * プレイヤーにぶつかるプレイヤーのHPを0になる
 * プレイヤーの武器が当たるとダメージを受ける  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyScript : MonoBehaviour {
	
	public GameObject player;
	public Transform target;
	public Transform muzzle;
	public GameObject weaponA;
	private float interval;
	private int EnemyHP = 3;
	private bool enemyWalk;
	private bool enemyLive;
	public Animator EnemyAnim;
	NavMeshAgent agent;

	void Awake () {
		agent = GetComponent<NavMeshAgent> ();
	}

	void Start () {
		enemyWalk = true;
		enemyLive = true;
	}
		
	void Update () {
		if (enemyWalk) {
			agent.SetDestination (target.position);
		}
		if (EnemyHP <= 0) {
			enemyWalk = false;
			enemyLive = false;
			EnemyAnim.SetBool ("EnemyDeath", true);
			Destroy (this.gameObject, 0.5f);

		}
		interval += 1 * Time.deltaTime;
		if (interval > 3) {
			Instantiate (weaponA, muzzle.transform.position, muzzle.transform.rotation);
			interval = 0;
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "player" && enemyLive) {
			PlayerScript.playerHP = 0;
		}
		if (col.gameObject.tag == "chalk") {
			EnemyHP--;
			if (EnemyHP > 0) {
				enemyWalk = false;
				EnemyAnim.SetBool ("EnemyDamage", true);
				Invoke ("EnemyDamageSetBoolFalse", 1.0f);
			}
		}
		if (col.gameObject.tag == "ChalkGrenade") {
			EnemyHP -= 3;
			if (EnemyHP > 0) {
				enemyWalk = false;
				EnemyAnim.SetBool ("EnemyDamage", true);
				Invoke ("EnemyDamageSetBoolFalse", 1.0f);
			}
		}
	}

	void EnemyDamageSetBoolFalse(){
		EnemyAnim.SetBool ("EnemyDamage", false);
		enemyWalk = true;
	}
 
}
