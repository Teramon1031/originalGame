﻿//パーティクルが再生し終わったらオブジェクトを削除 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalkBombScript : MonoBehaviour {

	ParticleSystem particle;

	void Awake () {
		particle = GetComponentInChildren<ParticleSystem> ();
	}

	void Start () {
		StartCoroutine (OnDestroyWhenParticleStop ());	
	}
		
	IEnumerator OnDestroyWhenParticleStop(){
		yield return new WaitWhile (() => particle.IsAlive (withChildren: true));
		Destroy (this.gameObject);
	}
}
