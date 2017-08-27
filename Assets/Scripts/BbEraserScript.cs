using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BbEraserScript : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "player") {
			BossBattleMuzzleScript.bbEraserNo++;
			Destroy (this.gameObject);
		}
	}
}
