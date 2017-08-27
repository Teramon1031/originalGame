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
	public Material[] materials = new Material[5];
	public GameObject text;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
		_renderer = this.GetComponent<Renderer> ();
		_player = GameObject.FindGameObjectWithTag ("player");
	}

	void Start () {
		_renderer.material = materials [Random.Range (0, 5)];
		this._rigidbody.AddRelativeForce (-transform.forward * 40);
		this._rigidbody.AddForce (Vector3.up * 15);
		text.SetActive (false);
	}

	void Update(){
		Vector3 _playerPos = _player.transform.position;
		Vector3 _thisPos = this.transform.position;
		float dis = Vector3.Distance (_playerPos,_thisPos);
		if (dis <= 1) {
			text.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {
				muzzleScript.chalkPowder++;
				Destroy (this.gameObject);
			}
		} else {
			text.SetActive (false);
		}
	}

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
