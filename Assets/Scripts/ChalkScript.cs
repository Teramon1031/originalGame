using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkScript : MonoBehaviour {
	
	private Rigidbody _rigidbody;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		this._rigidbody.AddForce (Vector3.up * 200);
		this._rigidbody.AddForce (Vector3.forward * 300);

	}

	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		Destroy (this.gameObject);
		if (col.gameObject.tag == "enemy") {
			enemyScript.EnemyHP--;
		}
	}
}
