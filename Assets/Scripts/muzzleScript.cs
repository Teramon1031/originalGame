using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muzzleScript : MonoBehaviour {

	public GameObject Chalk;
	public GameObject ChalkGrenade;
	private int ChalkNumber;
	public static int ChalkPowder = 10;
	public GameObject player;
	public Animator animator;
//	public Text ChalkNumberText;

	void Awake () {
		animator = player.GetComponent<Animator> ();
	}

	void Start () {
//		ChalkNumber = 10;
//		ChalkPowder = 5;
	}
	

	void Update () {
//		if (ChalkNumber > 0) {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Instantiate (Chalk, this.transform.position, this.transform.rotation);
			animator.SetBool ("Throw", true);
//				ChalkNumber--;
		} else {
			animator.SetBool ("Throw", false);
		}
//		}
//		if (ChalkPowder >= 5) {
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Instantiate (ChalkGrenade, this.transform.position, this.transform.rotation);
			animator.SetBool ("Throw", true);
//				ChalkPowder -= 5;
		} else {
			animator.SetBool ("Throw", false);
		}
//		}
//		ChalkNumberText.text = "Chalk : \t" + ChalkNumber.ToString ();
	}
}
