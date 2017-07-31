/* 敵がプレイヤーを追従し常にプレイヤーをむく
 * 5秒ごとに武器を発射
 * プレイヤーが近づくとプレイヤーのHPを0にする
 * プレイヤーの武器が当たるとダメージを受ける 
 */

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
	NavMeshAgent agent;

	void Awake () {
		agent = GetComponent<NavMeshAgent> ();
	}
		
	void Update () {
		agent.SetDestination(target.position);
		interval += 1 * Time.deltaTime;
		if (EnemyHP <= 0) {
			Destroy (this.gameObject);
		}

		if (interval > 5) {
			Instantiate (weaponA, muzzle.transform.position, muzzle.transform.rotation);
			interval = 0;
		}

	}

//	void PlayerApproach () {
//		Vector3 playerPos = player.transform.position;
//		Vector3 enemyPos = this.transform.position;
//		float dis = Vector3.Distance (playerPos, enemyPos);
//
//		if (dis < 1) {
//			PlayerScript.playerHP = 0;
//		}
//	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "player") {
			PlayerScript.playerHP = 0;
		}
		if (col.gameObject.tag == "chalk") {
			EnemyHP--;
		}
		if (col.gameObject.tag == "ChalkGrenade") {
			EnemyHP -= 3;
		}
	}
 
}
