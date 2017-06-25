using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyScript : MonoBehaviour {
	
	private int EnemyHP = 3;
	public GameObject player;
	public Transform target;
	NavMeshAgent agent;
	public Transform muzzle;
	public GameObject weaponA;

	public GameObject Enemies;

	private float interval;

	void Awake () {
		agent = GetComponent<NavMeshAgent> ();
	}

	void Start () {
		
	}

	void Update () {
//		transform.LookAt (target);
//		transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime;
		agent.SetDestination(target.position);
		PlayerApproach ();
		interval += 1 * Time.deltaTime;

		if (EnemyHP <= 0) {
			Destroy (this.gameObject);
		}

		if (interval > 5) {
			Instantiate (weaponA, muzzle.transform.position, muzzle.transform.rotation);
			interval = 0;
		}

	}

	void PlayerApproach () {
		Vector3 playerPos = player.transform.position;
		Vector3 enemyPos = this.transform.position;
		float dis = Vector3.Distance (playerPos, enemyPos);

		if (dis < 1) {
			PlayerScript.playerHP -= 5;
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "chalk") {
			EnemyHP--;
		}
		if (col.gameObject.tag == "ChalkGrenade") {
			EnemyHP -= 3;
		}
	}
 
}
