/* 生成されたらランダムに色がついて飛んでいく
 * プレイヤーがチョークに触れるとプレイヤーのもつ粉(集めるとチョーク爆弾になる)を増やす
 * ステージ以外にぶつかったらチョークを消滅させる */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkScript : MonoBehaviour {
	
	private Rigidbody _rigidbody;
	private Renderer _renderer;
	public Material[] materials = new Material[5];

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
		_renderer = this.GetComponent<Renderer> ();
	}

	void Start () {
		_renderer.material = materials [Random.Range (0, 5)];
		this._rigidbody.AddRelativeForce (-transform.forward * 40);
		this._rigidbody.AddForce (Vector3.up * 15);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "player") {
			muzzleScript.ChalkPowder++;
		}
		if (col.gameObject.tag != "stage") {
			Destroy (this.gameObject);
		}
	}
}
