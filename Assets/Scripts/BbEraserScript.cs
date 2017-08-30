using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BbEraserScript : MonoBehaviour {

	private GameObject _text;
	private GameObject _player;
	private Rigidbody _rigidbody;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		_rigidbody.AddForce (Vector3.up * 20);
	}

//	void Update () {
//		Vector3 _playerPos = _player.transform.position;
//		Vector3 _thisPos = this.transform.position;
//		float dis = Vector3.Distance (_playerPos,_thisPos);
//		if (dis <= 1) {
//			_text.SetActive (true);
//			if (Input.GetKeyDown (KeyCode.E)) {
//				BossBattleMuzzleScript.bbEraserNo++;
//				Destroy (this.gameObject);
//				_text.SetActive (false);
//			}
//		} else {
//			_text.SetActive (false);
//		}
//	}

//	void OnCollisionEnter(Collision col){
//		if (col.gameObject.tag == "player") {
//			BossBattleMuzzleScript.bbEraserNo++;
//			Destroy (this.gameObject);
//		}
//	}
}
