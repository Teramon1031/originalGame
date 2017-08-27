/* 生成されたらランダムに色がついて飛んでいく
 * プレイヤーがチョークに触れるとプレイヤーのもつ粉(集めるとチョーク爆弾になる)を増やす
 * ステージ以外にぶつかったらチョークを消滅させる */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkScriptB : MonoBehaviour {
	
	private Renderer _renderer;
	private GameObject _player;
	public Material[] materials = new Material[5];
	public GameObject text;

	void Awake () {
		_renderer = this.GetComponent<Renderer> ();
		_player = GameObject.FindGameObjectWithTag ("player");
	}

	void Start () {
		_renderer.material = materials [Random.Range (0, 5)];
	}

	void Update(){
		Vector3 _playerPos = _player.transform.position;
		Vector3 _thisPos = this.transform.position;
		float dis = Vector3.Distance (_playerPos,_thisPos);
		if (dis <= 1) {
			text.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {
				muzzleScript.chalkNo++;
				Destroy (this.gameObject);
			}
		} else {
			text.SetActive (false);
		}
	}

	void OnCollisionEnter(Collision col){
//		if (col.gameObject.tag == "player") {
//			muzzleScript.chalkNo++;
//			Destroy (this.gameObject);
//		}
	}
}
