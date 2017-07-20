using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkInstantiateScript : MonoBehaviour {

	public GameObject chalk; 

	void Start () {
		for (int i = 0; i < 10; i++) {
			Instantiate (chalk, new Vector3 
				(Random.Range (-25.0f, 25.0f), 3.05f, Random.Range (-25.0f, 25.0f)), transform.rotation);
		}
	}

	void Update () {
		
	}
}
