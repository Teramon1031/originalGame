using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muzzleScript : MonoBehaviour {


	public GameObject chalk;
	public GameObject chalkGrenade;
	public GameObject player;
	public Animator animator;
	public Text chalkText;
	public Text chalkGrenadeText;
	public static int chalkPowder;
	public static int chalkNo;

	void Awake () {
		animator = player.GetComponent<Animator> ();
	}

	void Start () {
		chalkNo = 10;
		chalkPowder = 20;
	}
	

	void Update () {
		if (chalkNo > 0) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				Instantiate (chalk, this.transform.position, this.transform.rotation);
				chalkNo--;
			}
		}

		if (chalkPowder >= 5) {
			if (Input.GetKeyDown (KeyCode.Alpha2)) {
				Instantiate (chalkGrenade, this.transform.position, this.transform.rotation);
				chalkPowder -= 5;
			}
		}
		if (Input.GetKey (KeyCode.Alpha1) || Input.GetKey (KeyCode.Alpha2)) {
			animator.SetBool ("Throw", true);
		} else {
			animator.SetBool ("Throw", false);
		}
			
		if (chalkNo <= 3) {
			chalkText.text = "チョーク：\t" + "<color=#aa2222>" + chalkNo.ToString () + "</color>";
		} else {
			chalkText.text = "チョーク：\t" + "<color=#ffffff>" + chalkNo.ToString () + "</color>";
		}

		if (Mathf.FloorToInt (chalkPowder / 5) <= 2) {
			chalkGrenadeText.text = "チョーク爆弾：\t" + "<color=#aa2222>" + Mathf.FloorToInt (chalkPowder / 5).ToString () + "</color>";
		} else {
			chalkGrenadeText.text = "チョーク爆弾：\t" + "<color=#ffffff>" + Mathf.FloorToInt (chalkPowder / 5).ToString () + "</color>";
		}
	}
}
