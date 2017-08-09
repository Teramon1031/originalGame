/* 生成されたらランダムに色がついて飛んでいく
 * プレイヤーがチョークに触れるとプレイヤーのもつ粉(集めるとチョーク爆弾になる)を増やす
 * ステージ以外にぶつかったらチョークを消滅させる */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkScriptB : MonoBehaviour {
	
	private Renderer _renderer;
	public Material[] materials = new Material[5];

	void Awake () {
		_renderer = this.GetComponent<Renderer> ();
	}

	void Start () {
		_renderer.material = materials [Random.Range (0, 5)];
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "player") {
			muzzleScript.chalkNo++;
			Destroy (this.gameObject);
		}
	}
}
