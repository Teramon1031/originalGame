using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BbEraserScript1 : MonoBehaviour {

	private Rigidbody _rigidbody;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		this._rigidbody.AddRelativeForce (-transform.forward * 80);
		this._rigidbody.AddForce (Vector3.up * 30);
	}

	void Update () {
		
	}

}
