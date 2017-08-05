
//プレイヤーが近づいた時&生成ポイントが視界外の時敵を生成する

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiatescript : MonoBehaviour {

	public GameObject player;
	public GameObject enemy;
	private bool PlayerIsNear;
	private bool IsRenderered;
	private bool TimeInterval;
	float timer;

	void Start () {
		
	}

	void Update () {
		IsRenderered = false;

	//プレイヤーと生成ポイントの距離を取得し10未満ならtrue,以上ならfalse
		Vector3 PosA = player.transform.position;
		Vector3 PosB = this.transform.position;
		float dis = Vector3.Distance (PosA,PosB);

		if (dis < 10) {
			PlayerIsNear = true;
		} else { 
			PlayerIsNear = false;
		}
	
		//プレイヤーが生成ポイントに近づいたかつカメラに写っていない時に生成
		timer -= Time.deltaTime;
		if (timer <= 0.0f) {
			if (IsRenderered == false && PlayerIsNear) { 
				Instantiate (enemy, this.transform.position, transform.rotation);
			}
			timer = 5.0f;
		}

	}

	private void OnWillRenderObject(){
		//メインカメラに映った時だけIsRenderedをfalseに
		if(Camera.current.tag == "MainCamera"){
			IsRenderered = true;
		}
	}
}
