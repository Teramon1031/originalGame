/* 生成されたらランダムに色がついて飛んでいく
 * プレイヤーがチョークに触れるとプレイヤーのもつ粉(集めるとチョーク爆弾になる)を増やす
 * ステージ以外にぶつかったらチョークを消滅させる */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkScript : MonoBehaviour {
	
	private Rigidbody _rigidbody;
	private Renderer _renderer;
	private GameObject _player;
//	private GameObject _text;
	public Material[] materials = new Material[5];

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
		_renderer = this.GetComponent<Renderer> ();
		_player = GameObject.FindGameObjectWithTag ("player");
//		_text = GameObject.FindGameObjectWithTag ("text");
	}

	void Start () {
		_renderer.material = materials [Random.Range (0, 5)];
		this._rigidbody.AddRelativeForce (-transform.forward * 40);
		this._rigidbody.AddForce (Vector3.up * 15);
//		_text.SetActive (false);
	}
//
//	void Update(){
//		Vector3 _playerPos = _player.transform.position;
//		Vector3 _thisPos = this.transform.position;
//		float dis = Vector3.Distance (_playerPos,_thisPos);
//		if (dis <= 1) {
////			_text.SetActive (true);
//			if (Input.GetKeyDown (KeyCode.E)) {
//				muzzleScript.chalkPowder++;
//				Destroy (this.gameObject);
////				_text.SetActive (false);
//			}
//		} else {
////			_text.SetActive (false);
//		}
//	}

	void OnCollisionEnter(Collision col){
//		if (col.gameObject.tag == "player") {
//			muzzleScript.chalkPowder++;
//			Destroy (this.gameObject);
//		}
		if (col.gameObject.tag == "enemy") {
			Destroy (this.gameObject);
		}

	}
}
