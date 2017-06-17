using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public GameObject Chalk;
	public Transform muzzle;
	public GameObject ChalkGrenade;

	void Start () {
		
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Instantiate (Chalk, muzzle.transform.position, muzzle.transform.rotation);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Instantiate (ChalkGrenade, muzzle.transform.position, muzzle.transform.rotation);
		}
	}
}