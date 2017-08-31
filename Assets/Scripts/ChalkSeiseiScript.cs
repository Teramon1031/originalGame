using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkSeiseiScript : MonoBehaviour {

	public GameObject chalk;

	void Start () {
		for (int i = 0; i < 10; i++) {
			Instantiate (chalk, new Vector3(Random.Range(13.5f,14.5f),4.2f,Random.Range(-23f,23f)),new Quaternion(0,Random.Range(0f,180f),0,0));
		}
		for (int i = 0; i < 10; i++) {
			Instantiate (chalk, new Vector3(Random.Range(-14.5f,-13.5f),4.2f,Random.Range(-23f,23f)),new Quaternion(0,Random.Range(0f,180f),0,0));
		}
		for (int i = 0; i < 5; i++) {
			Instantiate (chalk, new Vector3(Random.Range(-13.5f,14.5f),4.2f,Random.Range(23.5f,24.5f)), new Quaternion(0,Random.Range(0f,180f),0,0));
		}
	}
	

	void Update () {
		
	}
}
