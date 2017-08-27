using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BbEraserScript1 : MonoBehaviour {

	private Rigidbody _rigidbody;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		this._rigidbody.AddRelativeForce (-transform.forward * 40);
		this._rigidbody.AddForce (Vector3.up * 15);
	}

	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "boss") {
			BossScript.bossHP--;
			Destroy (this.gameObject);
		}
		if (col.gameObject.tag == "enemy") { 
			Destroy (this.gameObject);
		}
	}
}
