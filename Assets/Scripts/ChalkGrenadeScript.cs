/* 生成されたら飛んでいく
 * 当たり判定があったらChalkBombを生成し消滅 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkGrenadeScript : MonoBehaviour {
	
	private Rigidbody _rigidbody;
	public GameObject ChalkBomb;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		this._rigidbody.AddRelativeForce (-transform.forward * 20);
		this._rigidbody.AddRelativeForce (Vector3.up * 30);
	}
		
	void OnCollisionEnter (Collision col) {
		Instantiate (ChalkBomb, transform.position, transform.rotation);
		Destroy (this.gameObject);
	}
}
