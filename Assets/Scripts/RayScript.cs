using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour {

	public static bool frontObject;

	void Start () {
		
	}

	void Update () {
		Ray ();
	}

	void Ray () {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo, 1.0f) && hitInfo.collider.tag != "enemy") {
			frontObject = true;
		} else {
			frontObject = false;
		}
	}
}
