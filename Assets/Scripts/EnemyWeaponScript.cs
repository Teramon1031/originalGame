using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponScript : MonoBehaviour {

	private Rigidbody _rigidbody;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		this._rigidbody.AddForce (Vector3.up * 100);
		this._rigidbody.AddRelativeForce (Vector3.forward * 200);
	}

	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "player") {
			PlayerScript.playerHP--;
		}
		Destroy (this.gameObject);
	}
}
